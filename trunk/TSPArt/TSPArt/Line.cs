using System;
using System.Collections.Generic;
using System.Text;

namespace TSPArt
{
    public struct Line
    {
        public int StartIndex;
        public int EndIndex;

        public Line(int start, int end)
        {
            this.StartIndex = start;
            this.EndIndex = end;
        }
    }
}
