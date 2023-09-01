// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class PreorderUnitTest
{
    [Fact]
    public void Test()
    {
        var root1 = new Node(1, new List<Node>());
        var root1ChildNode3 = new Node(3, new List<Node>());
        root1ChildNode3.children.Add(new Node(5, new List<Node>()));
        root1ChildNode3.children.Add(new Node(6, new List<Node>()));
        root1.children.Add(root1ChildNode3);
        root1.children.Add(new Node(2, new List<Node>()));
        root1.children.Add(new Node(4, new List<Node>()));


        var root2 = new Node(1, new List<Node>());

        root2.children.Add(new Node(2, new List<Node>()));

        var root2ChildNode3 = new Node(3, new List<Node>());
        var root2ChildNode7 = new Node(7, new List<Node>());
        var root2ChildNode11 = new Node(11, new List<Node>());
        root2ChildNode11.children.Add(new Node(14, new List<Node>()));
        root2ChildNode7.children.Add(root2ChildNode11);
        root2ChildNode3.children.Add(new Node(6, new List<Node>()));
        root2ChildNode3.children.Add(root2ChildNode7);

        var root2ChildNode8 = new Node(8, new List<Node>());
        root2ChildNode8.children.Add(new Node(12, new List<Node>()));

        var root2ChildNode9 = new Node(9, new List<Node>());
        root2ChildNode9.children.Add(new Node(13, new List<Node>()));

        var root2ChildNode4 = new Node(4, new List<Node>());
        root2ChildNode4.children.Add(root2ChildNode8);

        var root2ChildNode5 = new Node(5, new List<Node>());
        root2ChildNode5.children.Add(root2ChildNode9);
        root2ChildNode5.children.Add(new Node(10, new List<Node>()));

        root2.children.Add(root2ChildNode3);
        root2.children.Add(root2ChildNode4);
        root2.children.Add(root2ChildNode5);

        var actual1 = Solution.PreOrder(root1);
        var actual2 = Solution.PreOrder(root2);

        Assert.Equal(new int[] { 1, 3, 5, 6, 2, 4 }, actual1);
        Assert.Equal(new int[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 }, actual2);
    }
}

