﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

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

        var actualNode = _solution.SortedArrayToBst(new int[] { -10, -3, 0, 5, 9 });
        var expectedNode = Util.CreateTreeNode(new List<int?> { 0, -10, 5, null, -3, null, 9 });
        var actual = Util.PreorderTraversal(actualNode);
        var expected = Util.PreorderTraversal(expectedNode);
        Assert.Equal(expected, actual);
    }
}
