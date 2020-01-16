using System;
using System.Collections.Generic;

namespace graphbasic
{

    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(9);

            graph.addEdge(1, 2);
            graph.addEdge(2, 3);
            graph.addEdge(2, 4);
            graph.addEdge(2, 5);
            graph.addEdge(1, 6);
            graph.addEdge(6, 7);
            graph.addEdge(4, 8);

            graph.BFS(1);

            graph.DFS(1);
        }
    }
    public class Graph
    {
        private int V; // No. of vertices 
        private List<int> []adj; //Adjacency Lists 

        // Constructor 
       public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge into the graph 
        public void addEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        // prints BFS traversal from a given source s 
        public void BFS(int s)
        {
            int cityCount = 0;
            // Mark all the vertices as not visited(By default 
            // set as false) 
            bool []visited = new bool[V];

            // Create a queue for BFS 
            Queue<int> queue = new Queue<int>();

            // Mark the current node as visited and enqueue it 
            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                // Dequeue a vertex from queue and print it 
                s = queue.Dequeue();
                System.Console.WriteLine(s + " ");

                // Get all adjacent vertices of the dequeued vertex s 
                // If a adjacent has not been visited, then mark it 
                // visited and enqueue it 
                var i = adj[s].GetEnumerator();
                while (i.MoveNext())
                {
                    int n = i.Current;
                    if (!visited[n])
                    {
                        visited[n] = true;
                        queue.Enqueue(n);                       
                    }
                }
            }

            Console.WriteLine("City Count {0}", cityCount);
        }

        void DFSUtil(int v, bool []visited)
        {
            // Mark the current node as visited and print it 
            visited[v] = true;
            Console.WriteLine(v + " ");

            // Recur for all the vertices adjacent to this vertex 
            var i = adj[v].GetEnumerator();
            while (i.MoveNext())
            {
                int n = i.Current;
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }
        public void DFS(int v)
        {
            // Mark all the vertices as not visited(set as 
            // false by default in java) 
            bool []visited = new bool[V];

            // Call the recursive helper function to print DFS traversal 
            DFSUtil(v, visited);
        }    

    }
}
// This code is contributed by Aakash Hasija 
