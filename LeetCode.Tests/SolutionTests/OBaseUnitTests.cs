namespace LeetCode.Tests.SolutionTests;

public class OptimalDivisionUnitTest
{
    [Fact]
    public void SingleTest()
    {
        int[] nums = [1000, 100, 10, 2];
        string actual = Solution.OptimalDivision(nums);
        string expected = "1000/(100/10/2)";
        Assert.Equal(actual, expected);
    }
}

public class OrangeRottingUnitTest
{
    public static TheoryData<int[][], int> Data => new()
    {
        { new int[][] { [2, 1, 1], [1, 1, 0], [0, 1, 1] }, 4 }, { new int[][] { [0, 2] }, 0 }
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[][] grid, int expected)
    {
        int actual = Solution.OrangeRotting(grid);
        Assert.Equal(expected, actual);
    }
}
