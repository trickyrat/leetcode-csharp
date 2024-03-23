namespace LeetCode.Tests.SolutionTests;

public class CanConstructUnitTest
{
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void Test(string ransomNote, string magazine, bool expected)
    {
        var actual = Solution.CanConstruct(ransomNote, magazine);
        Assert.Equal(expected, actual);
    }
}
