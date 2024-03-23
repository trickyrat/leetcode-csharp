// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FindTheWinnerUnitTest
{
    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(6, 5, 1)]
    public void MultipleDataTest(int n, int k, int expected)
    {
        var actual = Solution.FindTheWinner(n, k);
        Assert.Equal(expected, actual);
    }

}