// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using LeetCodecsharp.DataStructure;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TrimBSTUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateTreeNode([1, 0, 2]),
            1,
            2,
            Util.CreateTreeNode([1, null, 2])
        ];

        yield return
        [
            Util.CreateTreeNode([3, 0, 4, null, 2, null, null, 1]),
            1,
            3,
            Util.CreateTreeNode([3, 2, null, 1])
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int low, int high, TreeNode expected)
    {
        var actual = Solution.TrimBst(root, low, high);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }
}