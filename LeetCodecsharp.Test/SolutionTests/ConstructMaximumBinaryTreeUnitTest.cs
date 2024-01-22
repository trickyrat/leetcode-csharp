// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using LeetCodecsharp.DataStructure;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ConstructMaximumBinaryTreeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 3, 2, 1, 6, 0, 5 },
            Util.CreateTreeNode([6, 3, 5, null, 2, 0, null, null, 1])
        ];
        yield return
        [
            new[] { 3, 2, 1 },
            Util.CreateTreeNode([3, null, 2, null, 1])
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, TreeNode expected)
    {
        var actual = Solution.ConstructMaximumBinaryTree(nums);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }
}