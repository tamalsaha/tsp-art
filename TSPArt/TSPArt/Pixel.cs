using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TSPArt
{
    public struct Pixel
    {
        public int X;
        public int Y;
        public bool Visited;

        public Pixel(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Visited = false;
        }

        public Pixel(int x, int y, bool visited)
        {
            this.X = x;
            this.Y = y;
            this.Visited = visited;
        }

        public static implicit operator Point(Pixel a)
        {
            return new Point(a.X, a.Y);
        }
    }
}
