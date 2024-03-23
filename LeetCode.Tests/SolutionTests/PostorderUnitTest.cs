// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class PostorderUnitTest
{
    [Fact]
    public void Test()
    {
        var root1 = new Node(1, new List<Node>());
        var root1ChildNode3 = new Node(3, new List<Node>());
        root1ChildNode3.Children.Add(new Node(5, new List<Node>()));
        root1ChildNode3.Children.Add(new Node(6, new List<Node>()));
        root1.Children.Add(root1ChildNode3);
        root1.Children.Add(new Node(2, new List<Node>()));
        root1.Children.Add(new Node(4, new List<Node>()));
        
        var root2 = new Node(1, new List<Node>());

        root2.Children.Add(new Node(2, new List<Node>()));

        var root2ChildNode3 = new Node(3, new List<Node>());
        var root2ChildNode7 = new Node(7, new List<Node>());
        var root2ChildNode11 = new Node(11, new List<Node>());
        root2ChildNode11.Children.Add(new Node(14, new List<Node>()));
        root2ChildNode7.Children.Add(root2ChildNode11);
        root2ChildNode3.Children.Add(new Node(6, new List<Node>()));
        root2ChildNode3.Children.Add(root2ChildNode7);

        var root2ChildNode8 = new Node(8, new List<Node>());
        root2ChildNode8.Children.Add(new Node(12, new List<Node>()));

        var root2ChildNode9 = new Node(9, new List<Node>());
        root2ChildNode9.Children.Add(new Node(13, new List<Node>()));

        var root2ChildNode4 = new Node(4, new List<Node>());
        root2ChildNode4.Children.Add(root2ChildNode8);

        var root2ChildNode5 = new Node(5, new List<Node>());
        root2ChildNode5.Children.Add(root2ChildNode9);
        root2ChildNode5.Children.Add(new Node(10, new List<Node>()));

        root2.Children.Add(root2ChildNode3);
        root2.Children.Add(root2ChildNode4);
        root2.Children.Add(root2ChildNode5);

        var actual1 = Solution.PostOrder(root1);
        var actual2 = Solution.PostOrder(root2);

        Assert.Equal(new int[] { 5, 6, 3, 2, 4, 1 }, actual1);
        Assert.Equal(new int[] { 2, 6, 14, 11, 7, 3, 12, 8, 4, 13, 9, 10, 5, 1 }, actual2);
    }
}

