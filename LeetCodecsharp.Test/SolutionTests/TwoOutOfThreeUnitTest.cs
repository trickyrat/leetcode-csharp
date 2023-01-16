using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TwoOutOfThreeUnitTest
{
    private readonly Solution _solution;

    public TwoOutOfThreeUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 1, 1, 3, 2 }, new int[] { 2, 3 }, new int[] { 3 }, new int[] { 3, 2 })]
    [InlineData(new int[] { 3, 1 }, new int[] { 2, 3 }, new int[] { 1, 2 }, new int[] { 2, 3, 1 })]
    [InlineData(new int[] { 1, 2, 2 }, new int[] { 4, 3, 3 }, new int[] { 5 }, new int[] { })]
    public void MultipleDataTest(int[] nums1, int[] nums2, int[] nums3, IList<int> expected)
    {
        var actual = _solution.TwoOutOfThree(nums1, nums2, nums3);
        actual = actual.OrderBy(x => x).ToList();
        expected = expected.OrderBy(x => x).ToList();
        Assert.Equal(expected, actual);
    }
}