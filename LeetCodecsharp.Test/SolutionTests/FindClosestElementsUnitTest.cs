// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class FindClosestElementsUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, 3, new int[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, -1, new int[] { 1, 2, 3, 4 })]
    public void MultipleDataTest(int[] arr, int k, int x, IList<int> expected)
    {
        var actual = Solution.FindClosestElements(arr, k, x);
        Assert.Equal(expected, actual);
    }
}

