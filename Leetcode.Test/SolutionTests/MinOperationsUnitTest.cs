using Xunit;

namespace LeetCode.Test.SolutionTests;

public class MinOperationsUnitTest
{
    private readonly Solution _solution;

    public MinOperationsUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new string[] { "d1/", "d2/", "../", "d21/", "./" }, 2)]
    [InlineData(new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }, 3)]
    [InlineData(new string[] { "d1/", "../", "../", "../" }, 0)]
    public void Test(string[] logs, int expected)
    {
        var actual = _solution.MinOperations(logs);
        Assert.Equal(expected, actual);
    }
}