// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MinCostToHireWorkersUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 10, 20, 5 }, new[] { 70, 50, 30 }, 2, 105.00000, 105.000001
        ];

        yield return
        [
            new[] { 3, 1, 10, 10, 1 }, new[] { 4, 8, 2, 2, 7 }, 3, 30.66666, 30.6666667
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] quality, int[] wage, int k, double low, double high)
    {
        var actual = Solution.MinCostToHireWorkers(quality, wage, k);
        Assert.InRange(actual, low, high);
    }
}