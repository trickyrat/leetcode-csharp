namespace LeetCode.Tests.SolutionTests;

public class AddBinaryUnitTest
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    public void MultipleDataTest(string a, string b, string expected)
    {
        var actual = Solution.AddBinary(a, b);
        Assert.Equal(expected, actual);
    }
}