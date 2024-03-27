namespace LeetCode.Tests.SolutionTests;

public class CountWaysUnitTest
{
    public static TheoryData<int[][], int> Data =>
        new()
        {
            { [[6,10],[5,15]], 2 },
            { [[1,3],[10,20],[2,5],[4,8]], 4}
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[][] ranges, int expected)
    {
        var actual = Solution.CountWays(ranges);
        Assert.Equal(expected, actual);
    }
}