// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class AverageUnitTest
{
    [Theory]
    [InlineData(new int[] { 4000, 3000, 1000, 2000 }, 2500.00000)]
    [InlineData(new int[] { 1000, 2000, 3000 }, 2000.00000)]
    public void MultipleDataTest(int[] salary, double expected)
    {
        var actual = Solution.Average(salary);
        Assert.Equal(expected, actual);
    }

}