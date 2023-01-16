using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CanPartitionKSubsetsUnitTest
{
    private readonly Solution _solution;

    public CanPartitionKSubsetsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 4, 3, 2, 3, 5, 2, 1 }, 4, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 3, false)]
    public void Test(int[] nums, int k, bool expected)
    {
        var actual = _solution.CanPartitionKSubsets(nums, k);
        Assert.Equal(expected, actual);
    }
}