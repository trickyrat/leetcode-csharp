namespace LeetCode.Tests.SolutionTests;

public class FinalStringUnitTest
{
    [Theory]
    [InlineData("string", "rtsng")]
    [InlineData("poiinter", "ponter")]
    public void Test(string input, string expected)
    {
        var actual = Solution.FinalString(input);
        Assert.Equal(expected, actual);
    }
}
