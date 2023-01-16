// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCode.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CodecUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateTreeNode(new List<int?> { 2, 1, 3 }),
            Utilities.CreateTreeNode(new List<int?> { 2, 1, 3 })
        };
        yield return new object[]
       {
            null,
            null
       };
    }

    private readonly Codec _codec;

    public CodecUnitTest()
    {
        _codec = new Codec();
    }

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