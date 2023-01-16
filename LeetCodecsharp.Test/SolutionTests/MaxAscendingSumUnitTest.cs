using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MaxAscendingSumUnitTest
{
    private readonly Solution _solution;

    public MaxAscendingSumUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[]{10,20,30,5,10,50}, 65)]
    [InlineData(new int[]{10,20,30,40,50}, 150)]
    [InlineData(new int[]{12,17,15,13,10,11,12}, 33)]
    public void Test(int[] arr, int expected)
    {
        var actual = _solution.MaxAscendingSum(arr);
        Assert.Equal(expected, actual);
    }
}