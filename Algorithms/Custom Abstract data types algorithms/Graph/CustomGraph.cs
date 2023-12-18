using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class CustomGraph<T>
    {
        private Dictionary<T, List<T>> adjacencyList;

        public CustomGraph()
        {
            adjacencyList = new Dictionary<T, List<T>>();
        }

        public void AddVertex(T vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<T>();
            }
        }

        public void RemoveVertex(T vertex)
        {
            if (adjacencyList.ContainsKey(vertex))
            {
                // Remove the vertex from the adjacency list
                adjacencyList.Remove(vertex);

                // Remove references to the vertex from other lists
                foreach (var otherVertex in adjacencyList.Keys)
                {
                    adjacencyList[otherVertex].Remove(vertex);
                }
            }
        }

        public void AddEdge(T source, T destination)
        {
            if (!adjacencyList.ContainsKey(source))
            {
                AddVertex(source);
            }

            if (!adjacencyList.ContainsKey(destination))
            {
                AddVertex(destination);
            }

            adjacencyList[source].Add(destination);
            // If the graph is undirected, uncomment the line below:
            // adjacencyList[destination].Add(source);
        }

        public void RemoveEdge(T source, T destination)
        {
            if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
            {
                adjacencyList[source].Remove(destination);

                // If the graph is undirected, uncomment the line below:
                // adjacencyList[destination].Remove(source);
            }
        }

        public List<T> GetVertices()
        {
            return new List<T>(adjacencyList.Keys);
        }

        public List<T> GetNeighbors(T vertex)
        {
            if (adjacencyList.ContainsKey(vertex))
            {
                return adjacencyList[vertex];
            }
            return new List<T>();
        }

        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList.Keys)
            {
                Console.Write($" {vertex.ToString()}: ");
                foreach (var neighbor in adjacencyList[vertex])
                {
                    Console.Write($" {neighbor.ToString()} ");
                }
                Console.WriteLine();
            }
        }

    }



}
