// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class JobScheduingUnitTest
{
    private readonly Solution _solution;

    public JobScheduingUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3 }, new int[] { 3, 4, 5, 6 }, new int[] { 50, 10, 40, 70 }, 120)]
    [InlineData(new int[] { 1, 2, 3, 4, 6 }, new int[] { 3, 5, 10, 6, 9 }, new int[] { 20, 20, 100, 70, 60 }, 150)]
    [InlineData(new int[] { 1, 1, 1 }, new int[] { 2, 3, 4 }, new int[] { 5, 6, 4 }, 6)]
    public void MultipleDataTest(int[] startTime, int[] endTime, int[] profit, int expected)
    {
        var actual = _solution.JobScheduling(startTime, endTime, profit);
        Assert.Equal(expected, actual);
    }
}

