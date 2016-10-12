using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSolution.Entities.TrainSolution
{
    public class Route
    {
        public LinkedList<Node> Visited { get; set; }

        public double Distance { get; set; }

        public Route()
        {
            Visited = new LinkedList<Node>();
            Distance = 0;
        }
    }
}
