// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using LeetCodecsharp.DataStructure;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FindDuplicateSubtreesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateTreeNode([1, 2, 3, 4, null, 2, 4, null, null, 4]),
            new List<TreeNode>
            {
                Util.CreateTreeNode([4]),
                Util.CreateTreeNode([2, 4]),
            }
        ];

        yield return
        [
            Util.CreateTreeNode([2, 1, 1]),
            new List<TreeNode>
            {
                Util.CreateTreeNode([1])
            }
        ];

        yield return
        [
            Util.CreateTreeNode([2, 2, 2, 3, null, 3, null]),
            new List<TreeNode>
            {
                Util.CreateTreeNode([3]),
                Util.CreateTreeNode([2, 3]),
            }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, IList<TreeNode> expected)
    {
        var actual = Solution.FindDuplicateSubtrees(root);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }
}