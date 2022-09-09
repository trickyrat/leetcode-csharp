// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test;

public class SortedListToBSTUnitTest
{
    private readonly Solution _solution;
    public SortedListToBSTUnitTest()
    {
        _solution = new Solution();
    }
    [Fact]
    public void Test()
    {
        
        TreeNode actualNode = _solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
        TreeNode expectedNode = Utilities.CreateTreeNode(new List<int?> { 0, -10, 5, null, -3, null, 9 });
        List<int> actual = Utilities.PreorderTraversal(actualNode);
        List<int> expected = Utilities.PreorderTraversal(expectedNode);
        Assert.Equal(expected, actual);
    }
}
