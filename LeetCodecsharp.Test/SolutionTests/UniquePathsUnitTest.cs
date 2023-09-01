// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class UniquePathsUnitTest
{
    [Theory]
    [InlineData(3, 7, 28)]
    [InlineData(3, 2, 3)]
    public void MultipleDataTest(int m, int n, int expected)
    {
        var actual = Solution.UniquePaths(m, n);
        Assert.Equal(expected, actual);
    }
}

