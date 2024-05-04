﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class CodecUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateTreeNode([2, 1, 3]),
            Util.CreateTreeNode([2, 1, 3])
        ];
        yield return
        [
            null,
            null
        ];
    }

    private readonly Codec _codec = new();
    

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, TreeNode expected)
    {
        var treeNodeString = _codec.Serialize(root);
        var actual = _codec.Deserialize(treeNodeString);
        var comparer = new TreeNodeComparer();
        Assert.True(comparer.Equals(expected, actual));
    }
}