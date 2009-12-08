using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TSPArt
{
    interface ITsp
    {
        Line[] CalculatePath(Pixel[] nodes);
    }
}
