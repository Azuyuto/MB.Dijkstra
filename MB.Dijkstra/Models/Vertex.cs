using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Dijkstra.Models
{
    public class Vertex
    {
        public int Index { get; set; }
        public List<Edge> AdjacentVertex { get; set; }
        public int MaxDistance { get; set; }
        public bool Visited { get; set; }

        public Vertex()
        {
            AdjacentVertex = new List<Edge>();
            MaxDistance = int.MaxValue;
            Visited = false;
        }
    }
}
