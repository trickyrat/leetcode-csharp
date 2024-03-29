namespace LeetCode.Tests;

public class MinimumSumUnitTest
{
    public static TheoryData<int[], int> Data =>
        new()
        {
            {
                [8,6,1,5,3],
                9
            },
            {
                [5,4,8,7,10,2],
                13
            },
            {
                [6,5,4,3,4,5],
                -1
            }
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] nums, int expected)
    {
        var actual = Solution.MinimumSum(nums);
        Assert.Equal(expected, actual);
    }

}
