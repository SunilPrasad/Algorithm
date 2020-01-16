using System.Collections.Generic;
using System;

namespace DirectedGraphCyclicDependencyDetection
{
    class Graph
    {

        private readonly int V;
        private readonly List<int> []adj;

        public Graph(int V)
        {
            this.V = V;
            adj = new List<int>[V];

            for (int i = 0; i < V; i++)
                adj[i] = new List<int>();
        }

        private bool isCyclicUtil(int i, bool[] visited,bool[] recStack)
        {

            // Mark the current node as visited and 
            // part of recursion stack 
            if (recStack[i])
                return true;

            if (visited[i])
                return false;

            visited[i] = true;

            recStack[i] = true;
            List<int> children = adj[i];

            foreach(int c in children)
                if (isCyclicUtil(c, visited, recStack))
                    return true;

            recStack[i] = false;

            return false;
        }

        private void addEdge(int source, int dest)
        {
            adj[source].Add(dest);
        }


        private bool isCyclic()
        {

            // Mark all the vertices as not visited and 
            // not part of recursion stack 
            bool[] visited = new bool[V];
            bool[] recStack = new bool[V];


            // Call the recursive helper function to 
            // detect cycle in different DFS trees 
            for (int i = 0; i < V; i++)
                if (isCyclicUtil(i, visited, recStack))
                    return true;

            return false;
        }

        // Driver code 
        public static void main(String[] args)
        {
            Graph graph = new Graph(4);
            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(1, 2);
            graph.addEdge(2, 0);
            graph.addEdge(2, 3);
            graph.addEdge(3, 3);

            if (graph.isCyclic())
                Console.WriteLine("Graph contains cycle"); 
		else
                Console.WriteLine("Graph doesn't "
                                    + "contain cycle");
        }
    }
}


