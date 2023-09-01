using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class AddBinaryUnitTest
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    public void MultipleDataTest(string a, string b, string expected)
    {
        var actual = _solution.AddBinary(a, b);
        Assert.Equal(expected, actual);
    }
}