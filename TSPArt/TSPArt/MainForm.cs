using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace TSPArt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int ImageStride { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }

        private Bitmap bmpBW;
        private byte[] rgbValues;
        private Bitmap bmpGraph;
        private Bitmap bmpNN;
        private Bitmap bmpGreedy;
        private Bitmap bmp2opt;

        private Pixel[] nodes;
        private Line[] lastTour;

        public Pixel[] Nodes
        {
            get { return nodes == null ? new Pixel[0] : nodes; }
            set { nodes = value; }
        }
        public Line[] LastTour
        {
            get { return lastTour == null ? new Line[0] : lastTour; }
            set { lastTour = value; }
        }

        private void trackDotFacotor_Scroll(object sender, EventArgs e)
        {
            Process();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtPath.Text = @"..\..\..\single-black-cat.jpg";
            //txtPath.Text = @"..\..\..\small-single-black-cat.jpg";
            if (txtPath.Text != string.Empty && File.Exists(txtPath.Text))
            {
                Process();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Image.FromFile(openFileDialog.FileName).PixelFormat != PixelFormat.Format24bppRgb)
                {
                    MessageBox.Show("This is not a 24bppRgb image !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                txtPath.Text = openFileDialog.FileName;
                Process();
            }
        }

        private void Process()
        {
            pbOriginial.ImageLocation = txtPath.Text;

            ConvertBlackAndWhite(txtPath.Text);
            pbBW.Image = bmpBW;
            this.ImageWidth = bmpBW.Width;
            this.ImageHeight = bmpBW.Height;

            RetrievePixels(bmpBW);

            GenerateNodes();

            bmpGraph = GenerateBmp(nodes);
            pbGraph.Image = bmpGraph;

            tabImages.SelectedIndex = 2;
        }

        private void ConvertBlackAndWhite(string FileName)
        {
            Image imgTemp = Image.FromFile(FileName);
            ImageFormat ImageFormat = imgTemp.RawFormat;
            Bitmap bmpTemp = new Bitmap(imgTemp, imgTemp.Width, imgTemp.Height);

            if (bmpBW != null)
                bmpBW.Dispose();
            bmpBW = new Bitmap(bmpTemp.Width, bmpTemp.Height);
            float[][] FloatColorMatrix ={
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            using (Graphics gfxBW = Graphics.FromImage(bmpBW))
            {
                gfxBW.DrawImage(bmpTemp, new Rectangle(0, 0, bmpTemp.Width, bmpTemp.Height), 0, 0, bmpTemp.Width, bmpTemp.Height, GraphicsUnit.Pixel, Attributes);
            }
        }

        private void RetrievePixels(Bitmap bmp)
        {
            PixelFormat pxf = PixelFormat.Format24bppRgb;

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;

            int numBytes = bmpData.Stride * bmp.Height;
            this.ImageStride = bmpData.Stride;
            rgbValues = new byte[numBytes];

            Marshal.Copy(ptr, rgbValues, 0, numBytes);
            bmp.UnlockBits(bmpData);
        }

        private void GenerateNodes()
        {
            Random random = new Random();
            double dotFactor = trackDotFacotor.Value / 100.0;
            int[] raw = new int[this.ImageWidth * this.ImageHeight];
            for (int i = 0; i < raw.Length; i++)
                raw[i] = 0;
            int row, index;
            for (int y = 0; y < this.ImageHeight; y++)
            {
                row = y * this.ImageStride;
                for (int x = 0; x < this.ImageWidth; x++)
                {
                    index = row + x * 3;
                    int rgb = rgbValues[index] + rgbValues[index + 1] + rgbValues[index + 2];
                    double inv = ((1 - (float)rgb / 760));
                    inv = inv > 0 ? inv : 0;
                    inv = inv > 0.5 ? inv * 1.2 : inv;
                    inv = rgb < 100 ? 1 : inv;
                    double rand = random.NextDouble();
                    if (rand < inv && rand < dotFactor)
                    {
                        raw[y * this.ImageWidth + x] = 1;
                    }
                }
            }
            int w = this.ImageWidth;
            List<Pixel> nodeList = new List<Pixel>();
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == 1)
                {
                    nodeList.Add(new Pixel(i % w, i / w));
                }
            }
            nodes = nodeList.ToArray();
        }

        private Bitmap GenerateBmp(Pixel[] dots)
        {
            Bitmap bmp = new Bitmap(this.ImageWidth, this.ImageHeight);
            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;

            int numBytes = bmpData.Stride * bmp.Height;
            byte[] pixRGB = new byte[numBytes];

            Marshal.Copy(ptr, pixRGB, 0, numBytes);

            for (int i = 0; i < pixRGB.Length; i++)
            {
                pixRGB[i] = 255;
            }
            int w = this.ImageStride;
            int pos;
            foreach (Pixel p in dots)
            {
                pos = p.Y * w + p.X * 3;
                pixRGB[pos] = 0;
                pixRGB[pos + 1] = 0;
                pixRGB[pos + 2] = 0;
            }
            Marshal.Copy(pixRGB, 0, ptr, numBytes);

            bmp.UnlockBits(bmpData);
            return bmp;
        }

        private Bitmap GenerateBmp(Line[] lines)
        {
            Bitmap bmp = new Bitmap(this.ImageWidth, this.ImageHeight);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Line line in lines)
                {
                    g.DrawLine(new Pen(Color.Black), nodes[line.StartIndex], nodes[line.EndIndex]);
                }
            }
            return bmp;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeBmp();
        }

        private void DisposeBmp()
        {
            if (bmpBW != null) { bmpBW.Dispose(); bmpBW = null; }
            if (bmpGraph != null) { bmpGraph.Dispose(); bmpGraph = null; }
            if (bmpNN != null) { bmpNN.Dispose(); bmpNN = null; }
            if (bmpGreedy != null) { bmpGreedy.Dispose(); bmpGreedy = null; }
            if (bmp2opt != null) { bmp2opt.Dispose(); bmp2opt = null; }
        }

        private void btnExportBW_Click(object sender, EventArgs e)
        {
            if (bmpBW != null)
            {
                saveFileDialog.FileName = string.Empty;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bmpBW.Save(saveFileDialog.FileName);
                }
            }
        }
        
        private void btnExportGraph_Click(object sender, EventArgs e)
        {
            if (bmpGraph != null)
            {
                saveFileDialog.FileName = string.Empty;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bmpGraph.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnProcessNN_Click(object sender, EventArgs e)
        {
            btnProcessNN.Enabled = false;
            btnExportNN.Enabled = false;

            NearestNeighbor nn = new NearestNeighbor();
            Line[] nnPath = nn.CalculatePath(nodes);
            bmpNN = GenerateBmp(nnPath);
            pbNN.Image = bmpNN;

            lastTour = nnPath;


            btnProcessNN.Enabled = true;
            btnExportNN.Enabled = true;
        }

        private void btnExportNN_Click(object sender, EventArgs e)
        {
            if (bmpNN != null)
            {
                saveFileDialog.FileName = string.Empty;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bmpNN.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnDrawGreedy_Click(object sender, EventArgs e)
        {
            btnDrawGreedy.Enabled = false;
            btnExportGreedy.Enabled = false;

            GreedyTSP gt = new GreedyTSP();
            Line[] gtPath = gt.CalculatePath(nodes);
            bmpGreedy = GenerateBmp(gtPath);
            pbGreedy.Image = bmpGreedy;

            lastTour = gtPath;

            btnDrawGreedy.Enabled = true;
            btnExportGreedy.Enabled = true;

        }

        private void btnExportGreedy_Click(object sender, EventArgs e)
        {
            if (bmpGreedy != null)
            {
                saveFileDialog.FileName = string.Empty;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bmpGreedy.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnNext2Opt_Click(object sender, EventArgs e)
        {
            btnDraw2Opt.Enabled = false;
            btnNext2Opt.Enabled = false;
            btnExport2Opt.Enabled = false;
            TwoOptStep();
            btnDraw2Opt.Enabled = true;
            btnNext2Opt.Enabled = true;
            btnExport2Opt.Enabled = true;
        }

        private void btnDraw2Opt_Click(object sender, EventArgs e)
        {
            btnDraw2Opt.Enabled = false;
            btnNext2Opt.Enabled = false;
            btnExport2Opt.Enabled = false;
            TwoOptComplete();
            btnDraw2Opt.Enabled = true;
            btnNext2Opt.Enabled = true;
            btnExport2Opt.Enabled = true;
        }

        private void btnExport2Opt_Click(object sender, EventArgs e)
        {
            if (bmp2opt != null)
            {
                saveFileDialog.FileName = string.Empty;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bmp2opt.Save(saveFileDialog.FileName);
                }
            }
        }
        private void TwoOptStep()
        {
            TwoOpt twoOpt = new TwoOpt();
            Line[] optPath = twoOpt.CalculatePath(nodes, lastTour);
            bmp2opt = GenerateBmp(optPath);
            pb2Opt.Image = bmp2opt;
            lastTour = optPath;
        }

        private void TwoOptComplete()
        {
            TwoOpt twoOpt = new TwoOpt();
            Line[] optPath = twoOpt.DoComplete2Opt(nodes, lastTour);
            bmp2opt = GenerateBmp(optPath);
            pb2Opt.Image = bmp2opt;
            lastTour = optPath;
        }

    }
}
