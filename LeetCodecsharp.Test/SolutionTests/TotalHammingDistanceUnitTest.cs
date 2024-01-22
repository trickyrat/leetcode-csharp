using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TotalHammingDistanceUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 4, 14, 2 }, 6
        ];
        yield return
        [
            new[] { 4, 14, 4 }, 4
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int expected)
    {
        var actual = Solution.TotalHammingDistance(nums);
        Assert.Equal(expected, actual);
    }
}