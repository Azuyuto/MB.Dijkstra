using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Dijkstra.Models
{
    public class Edge
    {
        public int StartVertex { get; set; }
        public int EndVertex { get; set; }
        public int Weight { get; set; }
    }
}
