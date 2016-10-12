using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSolution.Entities.TrainSolution
{
    public class Node: IEquatable<Node>
    {
        public Guid Id { get; private set; }
        public string Value { get; set; }

        public IDictionary<Guid, double> Costs;
        public ICollection<Node> Neighbors;
        public Node()
        {
            Id = Guid.NewGuid();
            Neighbors = new List<Node>();
            Costs = new Dictionary<Guid, double>();
        }
        public Node(string value)
        {
            Id = Guid.NewGuid();
            Value = value;
            Neighbors = new List<Node>();
            Costs = new Dictionary<Guid, double>();
        }

        public bool Equals(Node other)
        {
            return this.Value == other.Value;
        }
    }
}
