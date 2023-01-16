using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ThreeEqualPartsUnitTest
{
    private readonly Solution _solution;

    public ThreeEqualPartsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] {1, 0, 1, 0, 1}, new int[] {0, 3})]
    [InlineData(new int[] {1, 1, 0, 1, 1}, new int[] {-1, -1})]
    [InlineData(new int[] {1, 1, 0, 0, 1}, new int[] {0, 2})]
    public void Test(int[] arr, int[] expected)
    {
        var actual = _solution.ThreeEqualParts(arr);
        Assert.Equal(expected, actual);
    }
}