using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ValidAnagramUnitTest
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void Test(string s, string t, bool expected)
    {
        var actual = Solution.IsAnagram(s, t);
        Assert.Equal(expected, actual);
    }
}