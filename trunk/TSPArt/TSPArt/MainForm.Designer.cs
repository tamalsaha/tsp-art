namespace TSPArt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabImages = new System.Windows.Forms.TabControl();
            this.tbpOrg = new System.Windows.Forms.TabPage();
            this.pbOriginial = new System.Windows.Forms.PictureBox();
            this.tbpBW = new System.Windows.Forms.TabPage();
            this.btnExportBW = new System.Windows.Forms.Button();
            this.pbBW = new System.Windows.Forms.PictureBox();
            this.tbpGraph = new System.Windows.Forms.TabPage();
            this.btnExportGraph = new System.Windows.Forms.Button();
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.tbpNN = new System.Windows.Forms.TabPage();
            this.btnExportNN = new System.Windows.Forms.Button();
            this.btnProcessNN = new System.Windows.Forms.Button();
            this.pbNN = new System.Windows.Forms.PictureBox();
            this.tbpGreedy = new System.Windows.Forms.TabPage();
            this.pbGreedy = new System.Windows.Forms.PictureBox();
            this.btnExportGreedy = new System.Windows.Forms.Button();
            this.btnDrawGreedy = new System.Windows.Forms.Button();
            this.tbp2Opt = new System.Windows.Forms.TabPage();
            this.btnExport2Opt = new System.Windows.Forms.Button();
            this.btnDraw2Opt = new System.Windows.Forms.Button();
            this.pb2Opt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trackDotFacotor = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnNext2Opt = new System.Windows.Forms.Button();
            this.tabImages.SuspendLayout();
            this.tbpOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginial)).BeginInit();
            this.tbpBW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBW)).BeginInit();
            this.tbpGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.tbpNN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNN)).BeginInit();
            this.tbpGreedy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreedy)).BeginInit();
            this.tbp2Opt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Opt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDotFacotor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabImages
            // 
            this.tabImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabImages.Controls.Add(this.tbpOrg);
            this.tabImages.Controls.Add(this.tbpBW);
            this.tabImages.Controls.Add(this.tbpGraph);
            this.tabImages.Controls.Add(this.tbpNN);
            this.tabImages.Controls.Add(this.tbpGreedy);
            this.tabImages.Controls.Add(this.tbp2Opt);
            this.tabImages.Location = new System.Drawing.Point(12, 92);
            this.tabImages.Name = "tabImages";
            this.tabImages.SelectedIndex = 0;
            this.tabImages.Size = new System.Drawing.Size(464, 341);
            this.tabImages.TabIndex = 0;
            // 
            // tbpOrg
            // 
            this.tbpOrg.Controls.Add(this.pbOriginial);
            this.tbpOrg.Location = new System.Drawing.Point(4, 22);
            this.tbpOrg.Name = "tbpOrg";
            this.tbpOrg.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrg.Size = new System.Drawing.Size(456, 315);
            this.tbpOrg.TabIndex = 0;
            this.tbpOrg.Text = "Original";
            this.tbpOrg.UseVisualStyleBackColor = true;
            // 
            // pbOriginial
            // 
            this.pbOriginial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginial.Location = new System.Drawing.Point(3, 3);
            this.pbOriginial.Name = "pbOriginial";
            this.pbOriginial.Size = new System.Drawing.Size(450, 309);
            this.pbOriginial.TabIndex = 0;
            this.pbOriginial.TabStop = false;
            // 
            // tbpBW
            // 
            this.tbpBW.Controls.Add(this.btnExportBW);
            this.tbpBW.Controls.Add(this.pbBW);
            this.tbpBW.Location = new System.Drawing.Point(4, 22);
            this.tbpBW.Name = "tbpBW";
            this.tbpBW.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBW.Size = new System.Drawing.Size(456, 315);
            this.tbpBW.TabIndex = 3;
            this.tbpBW.Text = "Black & White";
            this.tbpBW.UseVisualStyleBackColor = true;
            // 
            // btnExportBW
            // 
            this.btnExportBW.Location = new System.Drawing.Point(6, 6);
            this.btnExportBW.Name = "btnExportBW";
            this.btnExportBW.Size = new System.Drawing.Size(75, 23);
            this.btnExportBW.TabIndex = 4;
            this.btnExportBW.Text = "Export";
            this.btnExportBW.UseVisualStyleBackColor = true;
            this.btnExportBW.Click += new System.EventHandler(this.btnExportBW_Click);
            // 
            // pbBW
            // 
            this.pbBW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBW.Location = new System.Drawing.Point(3, 35);
            this.pbBW.Name = "pbBW";
            this.pbBW.Size = new System.Drawing.Size(450, 277);
            this.pbBW.TabIndex = 0;
            this.pbBW.TabStop = false;
            // 
            // tbpGraph
            // 
            this.tbpGraph.Controls.Add(this.btnExportGraph);
            this.tbpGraph.Controls.Add(this.pbGraph);
            this.tbpGraph.Location = new System.Drawing.Point(4, 22);
            this.tbpGraph.Name = "tbpGraph";
            this.tbpGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGraph.Size = new System.Drawing.Size(456, 315);
            this.tbpGraph.TabIndex = 4;
            this.tbpGraph.Text = "Graph";
            this.tbpGraph.UseVisualStyleBackColor = true;
            // 
            // btnExportGraph
            // 
            this.btnExportGraph.Location = new System.Drawing.Point(6, 6);
            this.btnExportGraph.Name = "btnExportGraph";
            this.btnExportGraph.Size = new System.Drawing.Size(75, 23);
            this.btnExportGraph.TabIndex = 3;
            this.btnExportGraph.Text = "Export";
            this.btnExportGraph.UseVisualStyleBackColor = true;
            this.btnExportGraph.Click += new System.EventHandler(this.btnExportGraph_Click);
            // 
            // pbGraph
            // 
            this.pbGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGraph.Location = new System.Drawing.Point(3, 35);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(450, 277);
            this.pbGraph.TabIndex = 1;
            this.pbGraph.TabStop = false;
            // 
            // tbpNN
            // 
            this.tbpNN.Controls.Add(this.btnExportNN);
            this.tbpNN.Controls.Add(this.btnProcessNN);
            this.tbpNN.Controls.Add(this.pbNN);
            this.tbpNN.Location = new System.Drawing.Point(4, 22);
            this.tbpNN.Name = "tbpNN";
            this.tbpNN.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNN.Size = new System.Drawing.Size(456, 315);
            this.tbpNN.TabIndex = 1;
            this.tbpNN.Text = "NN";
            this.tbpNN.UseVisualStyleBackColor = true;
            // 
            // btnExportNN
            // 
            this.btnExportNN.Location = new System.Drawing.Point(87, 6);
            this.btnExportNN.Name = "btnExportNN";
            this.btnExportNN.Size = new System.Drawing.Size(75, 23);
            this.btnExportNN.TabIndex = 2;
            this.btnExportNN.Text = "Export";
            this.btnExportNN.UseVisualStyleBackColor = true;
            this.btnExportNN.Click += new System.EventHandler(this.btnExportNN_Click);
            // 
            // btnProcessNN
            // 
            this.btnProcessNN.Location = new System.Drawing.Point(6, 6);
            this.btnProcessNN.Name = "btnProcessNN";
            this.btnProcessNN.Size = new System.Drawing.Size(75, 23);
            this.btnProcessNN.TabIndex = 1;
            this.btnProcessNN.Text = "Draw";
            this.btnProcessNN.UseVisualStyleBackColor = true;
            this.btnProcessNN.Click += new System.EventHandler(this.btnProcessNN_Click);
            // 
            // pbNN
            // 
            this.pbNN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNN.Location = new System.Drawing.Point(3, 35);
            this.pbNN.Name = "pbNN";
            this.pbNN.Size = new System.Drawing.Size(450, 277);
            this.pbNN.TabIndex = 0;
            this.pbNN.TabStop = false;
            // 
            // tbpGreedy
            // 
            this.tbpGreedy.Controls.Add(this.pbGreedy);
            this.tbpGreedy.Controls.Add(this.btnExportGreedy);
            this.tbpGreedy.Controls.Add(this.btnDrawGreedy);
            this.tbpGreedy.Location = new System.Drawing.Point(4, 22);
            this.tbpGreedy.Name = "tbpGreedy";
            this.tbpGreedy.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGreedy.Size = new System.Drawing.Size(456, 315);
            this.tbpGreedy.TabIndex = 5;
            this.tbpGreedy.Text = "Greedy";
            this.tbpGreedy.UseVisualStyleBackColor = true;
            // 
            // pbGreedy
            // 
            this.pbGreedy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGreedy.Location = new System.Drawing.Point(3, 35);
            this.pbGreedy.Name = "pbGreedy";
            this.pbGreedy.Size = new System.Drawing.Size(450, 277);
            this.pbGreedy.TabIndex = 5;
            this.pbGreedy.TabStop = false;
            // 
            // btnExportGreedy
            // 
            this.btnExportGreedy.Location = new System.Drawing.Point(87, 6);
            this.btnExportGreedy.Name = "btnExportGreedy";
            this.btnExportGreedy.Size = new System.Drawing.Size(75, 23);
            this.btnExportGreedy.TabIndex = 4;
            this.btnExportGreedy.Text = "Export";
            this.btnExportGreedy.UseVisualStyleBackColor = true;
            this.btnExportGreedy.Click += new System.EventHandler(this.btnExportGreedy_Click);
            // 
            // btnDrawGreedy
            // 
            this.btnDrawGreedy.Location = new System.Drawing.Point(6, 6);
            this.btnDrawGreedy.Name = "btnDrawGreedy";
            this.btnDrawGreedy.Size = new System.Drawing.Size(75, 23);
            this.btnDrawGreedy.TabIndex = 3;
            this.btnDrawGreedy.Text = "Draw";
            this.btnDrawGreedy.UseVisualStyleBackColor = true;
            this.btnDrawGreedy.Click += new System.EventHandler(this.btnDrawGreedy_Click);
            // 
            // tbp2Opt
            // 
            this.tbp2Opt.Controls.Add(this.btnNext2Opt);
            this.tbp2Opt.Controls.Add(this.btnExport2Opt);
            this.tbp2Opt.Controls.Add(this.btnDraw2Opt);
            this.tbp2Opt.Controls.Add(this.pb2Opt);
            this.tbp2Opt.Location = new System.Drawing.Point(4, 22);
            this.tbp2Opt.Name = "tbp2Opt";
            this.tbp2Opt.Padding = new System.Windows.Forms.Padding(3);
            this.tbp2Opt.Size = new System.Drawing.Size(456, 315);
            this.tbp2Opt.TabIndex = 2;
            this.tbp2Opt.Text = "2-Opt";
            this.tbp2Opt.UseVisualStyleBackColor = true;
            // 
            // btnExport2Opt
            // 
            this.btnExport2Opt.Location = new System.Drawing.Point(163, 6);
            this.btnExport2Opt.Name = "btnExport2Opt";
            this.btnExport2Opt.Size = new System.Drawing.Size(75, 23);
            this.btnExport2Opt.TabIndex = 4;
            this.btnExport2Opt.Text = "Export";
            this.btnExport2Opt.UseVisualStyleBackColor = true;
            this.btnExport2Opt.Click += new System.EventHandler(this.btnExport2Opt_Click);
            // 
            // btnDraw2Opt
            // 
            this.btnDraw2Opt.Location = new System.Drawing.Point(85, 6);
            this.btnDraw2Opt.Name = "btnDraw2Opt";
            this.btnDraw2Opt.Size = new System.Drawing.Size(75, 23);
            this.btnDraw2Opt.TabIndex = 3;
            this.btnDraw2Opt.Text = "Do it All";
            this.btnDraw2Opt.UseVisualStyleBackColor = true;
            this.btnDraw2Opt.Click += new System.EventHandler(this.btnDraw2Opt_Click);
            // 
            // pb2Opt
            // 
            this.pb2Opt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb2Opt.Location = new System.Drawing.Point(3, 35);
            this.pb2Opt.Name = "pb2Opt";
            this.pb2Opt.Size = new System.Drawing.Size(450, 277);
            this.pb2Opt.TabIndex = 0;
            this.pb2Opt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(448, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(82, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(367, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "C:\\small.jpg";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.png|All files|*.*";
            // 
            // trackDotFacotor
            // 
            this.trackDotFacotor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackDotFacotor.LargeChange = 1;
            this.trackDotFacotor.Location = new System.Drawing.Point(78, 41);
            this.trackDotFacotor.Maximum = 100;
            this.trackDotFacotor.Name = "trackDotFacotor";
            this.trackDotFacotor.Size = new System.Drawing.Size(398, 48);
            this.trackDotFacotor.TabIndex = 15;
            this.trackDotFacotor.Value = 1;
            this.trackDotFacotor.Scroll += new System.EventHandler(this.trackDotFacotor_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dot Factor:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image Files|*.jpg|All files|*.*";
            // 
            // btnNext2Opt
            // 
            this.btnNext2Opt.Location = new System.Drawing.Point(6, 6);
            this.btnNext2Opt.Name = "btnNext2Opt";
            this.btnNext2Opt.Size = new System.Drawing.Size(75, 23);
            this.btnNext2Opt.TabIndex = 5;
            this.btnNext2Opt.Text = "One Step";
            this.btnNext2Opt.UseVisualStyleBackColor = true;
            this.btnNext2Opt.Click += new System.EventHandler(this.btnNext2Opt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackDotFacotor);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabImages);
            this.Name = "MainForm";
            this.Text = "TSP Art Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabImages.ResumeLayout(false);
            this.tbpOrg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginial)).EndInit();
            this.tbpBW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBW)).EndInit();
            this.tbpGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.tbpNN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNN)).EndInit();
            this.tbpGreedy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGreedy)).EndInit();
            this.tbp2Opt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb2Opt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDotFacotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabImages;
        private System.Windows.Forms.TabPage tbpOrg;
        private System.Windows.Forms.TabPage tbpNN;
        private System.Windows.Forms.TabPage tbp2Opt;
        private System.Windows.Forms.TabPage tbpBW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox pbOriginial;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pbBW;
        private System.Windows.Forms.TabPage tbpGraph;
        private System.Windows.Forms.TrackBar trackDotFacotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.PictureBox pbNN;
        private System.Windows.Forms.PictureBox pb2Opt;
        private System.Windows.Forms.Button btnExportNN;
        private System.Windows.Forms.Button btnProcessNN;
        private System.Windows.Forms.Button btnExport2Opt;
        private System.Windows.Forms.Button btnDraw2Opt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnExportGraph;
        private System.Windows.Forms.Button btnExportBW;
        private System.Windows.Forms.TabPage tbpGreedy;
        private System.Windows.Forms.PictureBox pbGreedy;
        private System.Windows.Forms.Button btnExportGreedy;
        private System.Windows.Forms.Button btnDrawGreedy;
        private System.Windows.Forms.Button btnNext2Opt;
    }
}

