using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TSPArt
{
    public class NearestNeighbor : ITsp
    {
        #region ITsp Members

        public Line[] CalculatePath(Pixel[] nodes)
        {
            if (nodes == null || nodes.Length < 2)
                return new Line[0];

            List<Line> lines = new List<Line>();

            int curNode = 0;
            nodes[curNode].Visited = true;
            int nextNode;
            while (curNode >= 0)
            {
                //find the nearest unvisited vetex to nodes[curNodeIndex]
                nextNode = FindNEarestUnvisitedNode(nodes, curNode);
                if (nextNode >= 0)
                {
                    nodes[nextNode].Visited = true;
                    lines.Add(new Line(curNode, nextNode));
                }
                curNode = nextNode;
            }
            return lines.ToArray();
        }

        #endregion

        private double Distance(Pixel[] nodes, int i, int j)
        {
            return (nodes[i].X - nodes[j].X) * (nodes[i].X - nodes[j].X) + (nodes[i].Y - nodes[j].Y) * (nodes[i].Y - nodes[j].Y);
        }

        private int FindNEarestUnvisitedNode(Pixel[] nodes, int source)
        {
            int dest = -1;
            double minDist = double.MaxValue;
            double distance;
            for (int i = 0; i < nodes.Length; i++)
            {
                if (!nodes[i].Visited)
                {
                    distance = Distance(nodes, source, i);
                    if (distance < minDist)
                    {
                        dest = i;
                        minDist = distance;
                    }
                }
            }
            return dest;
        }
    }
}
