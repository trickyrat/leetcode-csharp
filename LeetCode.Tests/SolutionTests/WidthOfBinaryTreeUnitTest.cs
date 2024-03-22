// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using LeetCode.DataStructure;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class WidthOfBinaryTreeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateTreeNode([1, 3, 2, 5, 3, null, 9]),
            4
        ];
        yield return
        [
            Util.CreateTreeNode([1, 3, 2, 5, null, null, 9, 6, null, 7]),
            7
        ];
        yield return
        [
            Util.CreateTreeNode([1, 3, 2, 5]),
            2
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int expected)
    {
        var actual = Solution.WidthOfBinaryTree(root);
        Assert.Equal(expected, actual);
    }
}