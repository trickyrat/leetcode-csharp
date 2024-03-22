// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using LeetCode.DataStructure;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class TrimBSTUnitTest
{
    public static TheoryData<TreeNode, int, int, TreeNode> Data => new()
    {
        {
            Util.CreateTreeNode([1, 0, 2]),
            1,
            2,
            Util.CreateTreeNode([1, null, 2])
        },

        {
            Util.CreateTreeNode([3, 0, 4, null, 2, null, null, 1]),
            1,
            3,
            Util.CreateTreeNode([3, 2, null, 1])
        }
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(TreeNode root, int low, int high, TreeNode expected)
    {
        var actual = Solution.TrimBst(root, low, high);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }
}