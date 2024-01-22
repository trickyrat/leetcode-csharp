// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class InsertIntoMaxTreeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateTreeNode([4, 1, 3, null, null, 2]),
            5,
            Util.CreateTreeNode([5, 4, null, 1, 3, null, null, 2])
        ];
        yield return
        [
            Util.CreateTreeNode([5, 2, 4, null, 1]),
            3,
            Util.CreateTreeNode([5, 2, 4, null, 1, null, 3])
        ];
        yield return
        [
            Util.CreateTreeNode([5, 2, 3, null, 1]),
            4,
            Util.CreateTreeNode([5, 2, 4, null, 1, 3])
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int val, TreeNode expected)
    {
        var actual = Solution.InsertIntoMaxTree(root, val);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }

}

