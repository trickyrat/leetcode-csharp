// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ConnectUnitTest
{
    public static TheoryData<BinaryTreeNode, BinaryTreeNode> Data
    {
        get
        {
            var data = new TheoryData<BinaryTreeNode, BinaryTreeNode>
            {
                {
                    new BinaryTreeNode(),
                    new BinaryTreeNode()
                }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(BinaryTreeNode input, BinaryTreeNode expected)
    {
        var actual = Solution.Connect(input);
        //Assert.Equal(expected, actual);
    }
}