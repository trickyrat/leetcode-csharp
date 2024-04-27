namespace LeetCode.Tests;

public class DistanceTraveledUnitTest
{
    [Theory]
    [InlineData(5, 10, 60)]
    [InlineData(1, 2, 10)]
    public void Test(int mainTank, int additionalTank, int expected)
    {
        var actual = Solution.DistanceTraveled(mainTank, additionalTank);
        Assert.Equal(expected, actual);
    }
}
