// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using LeetCode.DataStructure;

using Xunit;

namespace LeetCode.Tests.SolutionTests;
public class AddOneRowUnitTest
{
    public static TheoryData<TreeNode, int, int, TreeNode> Data =>
        new()
        {
            {
                Util.CreateTreeNode([4, 2, 6, 3, 1, 5]),
                1,
                2,
                Util.CreateTreeNode([4, 1, 1, 2, null, null, 6, 3, 1, 5])
            },
            {
                Util.CreateTreeNode([4, 2, null, 3, 1]),
                1,
                3,
                Util.CreateTreeNode([4, 2, null, 1, 1, 3, null, null, 1])
            }
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(TreeNode root, int val, int depth, TreeNode expectedNode)
    {
        var actualNode = Solution.AddOneRow(root, val, depth);
        var actual = Util.PreorderTraversal(actualNode);
        var expected = Util.PreorderTraversal(expectedNode);
        Assert.Equal(expected, actual);
    }
}

