using MB.Dijkstra.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Dijkstra.Services
{
    public class DijkstraService
    {
        public static void Dijkstra(List<Vertex> vertices, int current = 0)
        {
            vertices[current].Visited = true;
            foreach (var edge in vertices[current].AdjacentVertex)
            {
                if(!vertices[edge.EndVertex].Visited)
                {
                    var distance = vertices[current].MaxDistance + edge.Weight;
                    if(distance < vertices[edge.EndVertex].MaxDistance)
                    {
                        vertices[edge.EndVertex].MaxDistance = distance;
                        Dijkstra(vertices, edge.EndVertex);
                    }
                }
            }
            vertices[current].Visited = false;
        }

        public static void FindShortestPathByFile(string path)
        {
            var text = File.ReadAllText(path);
            var json = JsonConvert.DeserializeObject<List<List<int>>>(text);
            var vertices = new List<Vertex>();
            int weight = 1;
            for (int i = 0; i < json.Count(); i++)
            {
                var newVertex = new Vertex()
                {
                    Index = i
                };
                foreach(var edge in json[i])
                {
                    newVertex.AdjacentVertex.Add(new Edge()
                    {
                        StartVertex = i,
                        EndVertex = edge,
                        Weight = weight
                    });
                    weight++;
                }
                vertices.Add(newVertex);
            }
            vertices[0].MaxDistance = 0;
            Dijkstra(vertices);
            foreach(var vertex in vertices)
            {
                Console.WriteLine(String.Format("Shortest path from 0 to {0} is: {1}", vertex.Index, vertex.MaxDistance));
            }
        }
    }
}
