//using System;
//using System.Collections.Generic;
//using System.Linq;
////using System.collection.
//namespace graphbasic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Graph graph = new Graph();
//            bool addtemple=false;
//            while (true)
//            {
//                var input = Console.ReadLine();

//                var data = input.Split(' ');

//                if (data[0] == "x")
//                    break;

//                if (data[0] == "t")
//                {
//                    addtemple = true;
//                    continue;
//                }

//                if (!addtemple)
//                {
//                    graph.AddEdge(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]));
//                }

//                if(addtemple)
//                {
//                    graph.AddTempleToCity(data[0]);
//                }
//            }
//          int res =  graph.FindNumberOfCittiesVisitWithoutTemple();

//            Console.WriteLine(res);
//        }
//    }

//    public class Vertex
//    {
//        public int data;
//        public List<int> adjanceyList;
//        public bool isHavingTemple;
//        public Vertex(int value)
//        {
//            data = value;         
//            adjanceyList = new List<int>();
//        }
//    }
//    public class Graph
//    {        

//        List<Vertex> vertices;

//        public Graph()
//        {
//            vertices = new List<Vertex>();
//        }

//        public Vertex AddVertex(int data)
//        {
//            // search for vertex 

//            var existingVertex = vertices.Find(x => x.data == data);

//            if(existingVertex==null)
//            {
//                existingVertex = new Vertex(data);
//                vertices.Add(existingVertex);
//            }

//            return existingVertex;
//        }

//        public void AddEdge(int data,int adjacentValue)
//        {
//            // search for vertex 
//            var existingVertex = vertices.Find(x => x.data == data);

//            if (existingVertex==null)
//            {
//                existingVertex = AddVertex(data);
//            }

//            // serh for adjacent vertex

//            var adjacentVertex = vertices.Find(x => x.data == adjacentValue);

//            if (adjacentVertex == null)
//            {
//                AddVertex(adjacentValue);
//            }

//            existingVertex.adjanceyList.Add(adjacentValue);
//        }

//        public void AddTempleToCity(string list)
//        {
//            var data = list.Split(' ').Select(x=>Convert.ToInt32(x));

//            foreach(var value in data)
//            {
//                var vertex = vertices.Find(x => x.data == value);

//                if(vertex!=null)
//                {
//                    vertex.isHavingTemple = true;
//                }
//            }
//        }

//        public int FindNumberOfCittiesVisitWithoutTemple()
//        {
//            int cityCount = 0;
//            foreach (var vertex in vertices)
//            {
//                if (!vertex.isHavingTemple)
//                {
//                    foreach (var data in vertex.adjanceyList)
//                    {
//                        var adjacentVertex = vertices.Find(x => x.data == data);

//                        if (!adjacentVertex.isHavingTemple)
//                            cityCount++;
//                    }
//                }
//            }

//            return cityCount;
//        }

//    }
//}
