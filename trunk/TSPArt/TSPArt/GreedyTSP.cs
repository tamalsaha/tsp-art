using System;
using System.Collections.Generic;
using System.Text;

namespace TSPArt
{
    public class GreedyTSP : ITsp
    {
        #region ITsp Members

        public Line[] CalculatePath(Pixel[] nodes)
        {
            int nodeCount = nodes.Length;
            int maxNode = nodes.Length - 1;
            if (nodeCount < 2)
                return new Line[0];

            List<Line> allEdges = new List<Line>();
            for (int i = 0; i < nodeCount; i++)
            {
                for (int j = 0; j < nodeCount; j++)
                {
                    if (i != j)
                    {
                        allEdges.Add(new Line(i, j));
                    }
                }
            }
            allEdges.Sort(delegate(Line x, Line y)
            {
                return (nodes[x.StartIndex].X - nodes[x.EndIndex].X) * (nodes[x.StartIndex].X - nodes[x.EndIndex].X) + (nodes[x.StartIndex].Y - nodes[x.EndIndex].Y) * (nodes[x.StartIndex].Y - nodes[x.EndIndex].Y)
                        - (nodes[y.StartIndex].X - nodes[y.EndIndex].X) * (nodes[y.StartIndex].X - nodes[y.EndIndex].X) - (nodes[y.StartIndex].Y - nodes[y.EndIndex].Y) * (nodes[y.StartIndex].Y - nodes[y.EndIndex].Y);
            });

            int[] visits = new int[nodeCount];
            Line[] path = new Line[maxNode];
            int pathLength = 0;
            Line edge;

            edge = allEdges[0];
            path[pathLength++] = edge;
            allEdges.RemoveAt(0);
            visits[edge.StartIndex]++;
            visits[edge.EndIndex]++;

            while (pathLength < maxNode)
            {
                for (int i = 0; i < allEdges.Count; )
                {
                    edge = allEdges[i];
                    if (visits[edge.StartIndex] > 1 || visits[edge.EndIndex] > 1)
                    {
                        allEdges.RemoveAt(i);
                    }
                    else if ((visits[edge.StartIndex] == 0 && visits[edge.EndIndex] == 1)
                        || (visits[edge.StartIndex] == 1 && visits[edge.EndIndex] == 0))
                    {
                        path[pathLength++] = edge;
                        allEdges.RemoveAt(i);
                        visits[edge.StartIndex]++;
                        visits[edge.EndIndex]++;
                        break;
                    }
                    else
                        i++;
                }
            };
            return path;
        }

        #endregion
    }
}
