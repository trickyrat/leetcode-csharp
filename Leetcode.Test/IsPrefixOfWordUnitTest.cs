using Xunit;

namespace Leetcode.Test;

public class IsPrefixOfWordUnitTest
{
    private readonly Solution _solution;

    public IsPrefixOfWordUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("i love eating burger", "burg", 4)]
    [InlineData("this problem is an easy problem", "pro", 2)]
    [InlineData("i am tired", "you", -1)]
    public void Test(string sentence, string searchWord, int expected)
    {
        var actual = _solution.IsPrefixOfWord(sentence, searchWord);
        Assert.Equal(expected, actual);
    }
}