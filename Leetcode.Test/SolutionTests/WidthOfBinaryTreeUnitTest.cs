// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class WidthOfBinaryTreeUnitTest
{
    private readonly Solution _solution;

    public WidthOfBinaryTreeUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateTreeNode(new List<int?>{ 1,3,2,5,3,null,9}),
            4
        };
        yield return new object[]
        {
            Utilities.CreateTreeNode(new List<int?>{ 1,3,2,5,null,null,9,6,null,7}),
            7
        };
        yield return new object[]
        {
            Utilities.CreateTreeNode(new List<int?>{ 1,3,2,5}),
            2
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int expected)
    {
        var actual = _solution.WidthOfBinaryTree(root);
        Assert.Equal(expected, actual);
    }
}


