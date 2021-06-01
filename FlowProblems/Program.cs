using System;

namespace FlowProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[,] {
              //   1   2   3   4   5 
                {  0, 20, 30, 10,  0 },
                {  0,  0, 40,  0, 30 },
                {  0,  0,  0, 10, 20 },
                {  0,  0,  5,  0, 20 },
                {  0,  0,  0,  0,  0 },
            };
            FordFulkersonMethod m = new FordFulkersonMethod();

            Console.WriteLine("The maximum possible flow is "
                              + m.Seek(graph, 0, 4));
        }
    }
}
