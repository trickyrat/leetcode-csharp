// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FinalPricesUnitTest
{
    public static TheoryData<int[], int[]> Data
    {
        get
        {
            var data = new TheoryData<int[], int[]>
            {
                { [8, 4, 6, 2, 3], [4, 2, 4, 2, 3] },
                { [1, 2, 3, 4, 5], [1, 2, 3, 4, 5] },
                { [10, 1, 1, 6], [9, 0, 1, 6] },
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] prices, int[] expected)
    {
        var actual = Solution.FinalPrices(prices);
        Assert.Equal(expected, actual);
    }
}