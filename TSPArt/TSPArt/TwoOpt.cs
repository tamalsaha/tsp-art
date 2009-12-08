using System;
using System.Collections.Generic;
using System.Text;

namespace TSPArt
{
    public class TwoOpt
    {
        //        #region ITsp Members

        private double Distance(Pixel firstNode, Pixel secNode)
        {
            return (firstNode.X - secNode.X) * (firstNode.X - secNode.X) + (firstNode.Y - secNode.Y) * (firstNode.Y - secNode.Y);
        }

        public Line[] CalculatePath(Pixel[] nodes, Line[] tour)
        {
            if (tour == null || tour.Length < 2)
                return new Line[0];

            List<Line> twoOptTour = new List<Line>(tour);
            double maxImprovement = 0.0;

            twoOptTour = OneStep(nodes, twoOptTour, ref maxImprovement);

            return twoOptTour.ToArray();
        }

        public Line[] DoComplete2Opt(Pixel[] nodes, Line[] tour)
        {
            if (tour == null || tour.Length < 2)
                return new Line[0];

            List<Line> twoOptTour = new List<Line>(tour);
            double improvement = 0.0;
            do
            {
                improvement = 0.0;
                twoOptTour = OneStep(nodes, twoOptTour, ref improvement);
            } while (improvement > 0.0);
            return twoOptTour.ToArray();
        }

        public struct LineNode
        {
            int linePosition;
            int node;

            public int LinePosition
            {
                get { return linePosition; }
                set { linePosition = value; }
            }

            public int Node
            {
                get { return node; }
                set { node = value; }
            }
        }

        public class Comparer : IComparer<LineNode>
        {
            public int Compare(LineNode a, LineNode b)
            {
                int result = a.Node.CompareTo(b.Node);
                return result;
            }
        }

        public List<Line> OneStep(Pixel[] nodes, List<Line> tour, ref double maxImprovement)
        {


            List<Line> tempTour10 = new List<Line>();
            for (int i = 0; i < tour.Count; i++)
                tempTour10.Add(tour[i]);

            Line startNode = DetectingStartNode(tempTour10);

            // This methos is designed to convert the list lines to a tour 
            List<Line> sortedTour = MakeTour(tour, tempTour10, ref startNode);
            tour = sortedTour;

            
            List<Line> newTwoOptTour = new List<Line>(tour);

            Line firstEdgeRepalced = new Line();
            Line secEdgeRepalced = new Line();
            double localMaxImprovement = 0.0;
            int firstLineTourPosition = 0;
            int secLineTourPosition = 0;
            for (int i = 0; i < newTwoOptTour.Count - 2; i++)
            {
                Line firstEdge = newTwoOptTour[i];
                Line secondEdge = newTwoOptTour[i + 2];
                for (int j = i + 2; j < newTwoOptTour.Count; j++)
                {
                    secondEdge = newTwoOptTour[j];
                    double improvement =
                        (Distance(nodes[firstEdge.StartIndex], nodes[firstEdge.EndIndex]) +
                        Distance(nodes[secondEdge.StartIndex], nodes[secondEdge.EndIndex])) -
                        (Distance(nodes[firstEdge.StartIndex], nodes[secondEdge.StartIndex]) +
                        Distance(nodes[firstEdge.EndIndex], nodes[secondEdge.EndIndex]));
                    if (improvement > localMaxImprovement)
                    {
                        localMaxImprovement = improvement;
                        firstEdgeRepalced = firstEdge;
                        secEdgeRepalced = secondEdge;
                        firstLineTourPosition = i;
                        secLineTourPosition = j;
                    }
                }
            }
            if (localMaxImprovement > 0.0)
            {
                Line tempLine = new Line();
                Line tempLine2 = new Line();
                tempLine.StartIndex = newTwoOptTour[firstLineTourPosition].StartIndex;
                tempLine.EndIndex = newTwoOptTour[secLineTourPosition].StartIndex;
                tempLine2.StartIndex = newTwoOptTour[firstLineTourPosition].EndIndex;
                tempLine2.EndIndex = newTwoOptTour[secLineTourPosition].EndIndex;
                newTwoOptTour[firstLineTourPosition] = tempLine;
                newTwoOptTour[secLineTourPosition] = tempLine2;

                for (int i = firstLineTourPosition + 1; i < secLineTourPosition; i++)
                {
                    tempLine.StartIndex = newTwoOptTour[i].EndIndex;
                    tempLine.EndIndex = newTwoOptTour[i].StartIndex;
                    newTwoOptTour[i] = tempLine;
                }


                //This method designed to sort the new Tour after performing 2Opt Algorithm over it.
                sortedTour = ResortAffectedTour(newTwoOptTour, firstLineTourPosition, secLineTourPosition);
                newTwoOptTour = sortedTour;

                maxImprovement = localMaxImprovement;
            }

            return newTwoOptTour;
        }

        private static List<Line> ResortAffectedTour(List<Line> newTwoOptTour, int firstLineTourPosition, int secLineTourPosition)
        {
            List<Line> tempTour = new List<Line>();
            for (int i = 0; i < newTwoOptTour.Count; i++)
                tempTour.Add(newTwoOptTour[i]);

            for (int i = firstLineTourPosition + 1; i < secLineTourPosition; i++)
            {
                for (int j = firstLineTourPosition + 1; j < secLineTourPosition; j++)
                {
                    if (tempTour[i - 1].EndIndex == newTwoOptTour[j].StartIndex)
                    {
                        tempTour[i] = newTwoOptTour[j];
                        break;
                    }
                }
            }
            return tempTour;
        }

        private static List<Line> MakeTour(List<Line> tour, List<Line> tempTour10, ref Line startNode)
        {
            List<Line> tourTemp = new List<Line>();
            tourTemp.Add(startNode);
            tempTour10.Remove(startNode);

            do
            {
                for (int j = 0; j < tempTour10.Count; j++)
                {
                    if (tourTemp[tourTemp.Count - 1].EndIndex == tempTour10[j].StartIndex)
                    {
                        tourTemp.Add(tempTour10[j]);
                        tempTour10.RemoveAt(j);
                        break;
                    }
                    else if ((tourTemp[tourTemp.Count - 1].EndIndex == tempTour10[j].EndIndex))
                    {
                        Line tmpLine12 = new Line();
                        tmpLine12.StartIndex = tempTour10[j].EndIndex;
                        tmpLine12.EndIndex = tempTour10[j].StartIndex;
                        tourTemp.Add(tmpLine12);
                        tempTour10.RemoveAt(j);
                        break;
                    }
                }
            } while (tourTemp.Count < tour.Count);
            return tourTemp;
        }

        private static Line DetectingStartNode(List<Line> tempTour10)
        {
            List<LineNode> lineNodesList = new List<LineNode>();
            for (int i = 0; i < tempTour10.Count; i++)
            {
                LineNode ln = new LineNode();
                ln.LinePosition = i;
                ln.Node = tempTour10[i].StartIndex;
                lineNodesList.Add(ln);
                ln.Node = tempTour10[i].EndIndex;
                lineNodesList.Add(ln);
            }
            Comparer c = new Comparer();
            lineNodesList.Sort(c);
            do
            {
                for (int i = 0; i < lineNodesList.Count - 1; i++)
                {
                    if (lineNodesList[i].Node == lineNodesList[i + 1].Node)
                    {
                        lineNodesList.Remove(lineNodesList[i + 1]);
                        lineNodesList.Remove(lineNodesList[i]);
                    }
                }
            } while (lineNodesList.Count > 2);

            Line startNode = new Line();
            if (lineNodesList[0].Node == tempTour10[lineNodesList[0].LinePosition].StartIndex)
                startNode = tempTour10[lineNodesList[0].LinePosition];
            else
            {
                startNode.StartIndex = tempTour10[lineNodesList[0].LinePosition].EndIndex;
                startNode.EndIndex = tempTour10[lineNodesList[0].LinePosition].StartIndex;
            }

            Line endNode = new Line();
            if (lineNodesList[1].Node == tempTour10[lineNodesList[1].LinePosition].EndIndex)
                endNode = tempTour10[lineNodesList[1].LinePosition];
            else
            {
                endNode.StartIndex = tempTour10[lineNodesList[1].LinePosition].EndIndex;
                endNode.EndIndex = tempTour10[lineNodesList[1].LinePosition].StartIndex;
            }
            Line t2 = new Line();
            t2 = tempTour10[lineNodesList[1].LinePosition];
            tempTour10.RemoveAt(lineNodesList[0].LinePosition);
            tempTour10.Remove(t2);
            tempTour10.Insert(0, startNode);
            tempTour10.Insert(tempTour10.Count, endNode);
            return startNode;
        }

        //        #endregion

    }
}
