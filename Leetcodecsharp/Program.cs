//using Leetcodecsharp.DataStructure;

using System;
using System.Collections.Generic;

namespace Leetcodecsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pq = new PriorityQueue<int, int>();
            var list = new List<int> { 4, 5, 8, 2 };
            foreach (int item in list)
            {
                pq.Enqueue(item, item);
            }
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(pq.Dequeue() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Hello World!");
        }
    }
}
