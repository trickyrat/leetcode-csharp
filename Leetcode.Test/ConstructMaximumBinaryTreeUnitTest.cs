// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test;
public class ConstructMaximumBinaryTreeUnitTest
{
    private readonly Solution _solution;

    public ConstructMaximumBinaryTreeUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[]{ 3, 2, 1, 6, 0, 5 },
            Utilities.CreateTreeNodeIteratively(new List<int?> { 6, 3, 5, null, 2, 0, null, null, 1 })
        };
        yield return new object[]
        {
            new int[]{ 3, 2, 1 },
            Utilities.CreateTreeNodeIteratively(new List<int?> { 3,null,2,null,1 })
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, TreeNode expected)
    {
        var actual = _solution.ConstructMaximumBinaryTree(nums);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }
}

