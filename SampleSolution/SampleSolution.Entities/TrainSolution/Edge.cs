using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSolution.Entities.TrainSolution
{
    public class Edge: IEquatable<Edge>
    {
        public Node Start { get; set; }

        public Node End { get; set; }

        public bool IsDirected { get; set; }

        public double Cost { get; set; }

        public Edge(Node start, Node end, bool isDirected)
        {
            Start = start;
            End = end;
            IsDirected = isDirected;
        }

        public Edge(Node start, Node end, bool isDirected, double cost)
        {
            Start = start;
            End = end;
            IsDirected = isDirected;
            Cost = cost;
        }

        public bool Equals(Edge other)
        {
            return this.Start == other.Start && this.End == other.End;
        }
    }
}
