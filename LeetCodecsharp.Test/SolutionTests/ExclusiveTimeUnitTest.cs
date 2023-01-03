// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class ExclusiveTimeUnitTest
{
    private readonly Solution _solution;

    public ExclusiveTimeUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(2, new string[] { "0:start:0", "1:start:2", "1:end:5", "0:end:6" }, new int[] { 3, 4 })]
    [InlineData(1, new string[] { "0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7" }, new int[] { 8 })]
    [InlineData(2, new string[] { "0:start:0", "0:start:2", "0:end:5", "1:start:6", "1:end:6", "0:end:7" }, new int[] { 7, 1 })]
    [InlineData(2, new string[] { "0:start:0", "0:start:2", "0:end:5", "1:start:7", "1:end:7", "0:end:8" }, new int[] { 8, 1 })]
    [InlineData(1, new string[] { "0:start:0", "0:end:0" }, new int[] { 1 })]
    public void MultipleDataTest(int n, IList<string> logs, int[] expected)
    {
        var actual = _solution.ExclusiveTime(n, logs);
        Assert.Equal(expected, actual);
    }
}

