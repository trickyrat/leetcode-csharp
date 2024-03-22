// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class AverageUnitTest
{
    public static TheoryData<int[], double> Data
    {
        get
        {
            var data = new TheoryData<int[], double>
            {
                { [4000, 3000, 1000, 2000], 2500.00000 },
                { [1000, 2000, 3000], 2000.00000 }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(int[] salary, double expected)
    {
        var actual = Solution.Average(salary);
        Assert.Equal(expected, actual);
    }
}