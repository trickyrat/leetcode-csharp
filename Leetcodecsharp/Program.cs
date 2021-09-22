using Leetcodecsharp.DataStructure;

using System;
using System.Collections.Generic;

namespace Leetcodecsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = Utils.InitLinkedList(new List<int> { 1, 2, 3, 4, 5 });
            ListNode actual = Solution.MiddleNode(head);
            ListNode expected = Utils.InitLinkedList(new List<int> { 3, 4, 5 });

            Console.WriteLine($"actual:{Utils.PrintListNode(actual)}");
            Console.WriteLine($"expected:{Utils.PrintListNode(expected)}");
            Console.WriteLine("Hello World!");
        }
    }
}
