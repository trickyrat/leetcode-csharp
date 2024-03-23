// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class CalPointsUnitTest
{
    public static TheoryData<string[], int> Data
    {
        get
        {
            var data = new TheoryData<string[], int>
            {
                { ["5", "2", "C", "D", "+"], 30 },
                { ["5", "-2", "4", "C", "D", "9", "+", "+"], 27 },
                { ["1"], 1 }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(string[] input, int expected)
    {
        var actual = Solution.CalPoints(input);
        Assert.Equal(expected, actual);
    }
}