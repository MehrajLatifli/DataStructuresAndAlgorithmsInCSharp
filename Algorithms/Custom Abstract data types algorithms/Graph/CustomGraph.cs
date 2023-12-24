using System;
using System.Collections.Generic;
using System.Linq;

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
                adjacencyList.Remove(vertex);

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
        }

        public void RemoveEdge(T source, T destination)
        {
            if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
            {
                adjacencyList[source].Remove(destination);
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

        public int GetVertexIndex(T vertex)
        {
            List<T> vertices = GetVertices();
            return vertices.IndexOf(vertex);
        }

        public void DepthFirstSearchTraversal(T startVertex)
        {
           
            Stack<T> stack = new Stack<T>();
            
            HashSet<T> visited = new HashSet<T>();

           
            stack.Push(startVertex);
            visited.Add(startVertex);

            while (stack.Count > 0)
            {
               
                T currentVertex = stack.Pop();
                Console.Write($"{currentVertex.ToString()} ");

              
                foreach (var neighbor in adjacencyList[currentVertex])
                {
                    
                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }
            Console.WriteLine();
        }

        
        public void BreadthFirstSearchTraversal(T startVertex)
        {
            HashSet<T> visited = new HashSet<T>();
            Queue<T> queue = new Queue<T>();

            visited.Add(startVertex);
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                T currentVertex = queue.Dequeue();
                Console.Write($" {currentVertex.ToString()} ");

                foreach (var neighbor in adjacencyList[currentVertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

    }
}
