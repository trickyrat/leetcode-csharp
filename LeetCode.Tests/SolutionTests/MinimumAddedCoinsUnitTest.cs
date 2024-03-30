namespace LeetCode.Tests.SolutionTests;

public class MinimumAddedCoinsUnitTest
{
    public static TheoryData<int[], int, int> Data =>
        new()
        {
            { [1,4,10], 19, 2},
            { [1,4,10,5,7,19], 19, 1},
            { [1,1,1], 20, 3},
        };


    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] coins, int target, int expected)
    {
        var actual = Solution.MinimumAddedCoins(coins, target);
        Assert.Equal(expected, actual);
    }
}