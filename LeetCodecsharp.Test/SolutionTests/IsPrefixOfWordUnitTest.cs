// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class IsPrefixOfWordUnitTest
{
    [Theory]
    [InlineData("i love eating burger", "burg", 4)]
    [InlineData("this problem is an easy problem", "pro", 2)]
    [InlineData("i am tired", "you", -1)]
    public void Test(string sentence, string searchWord, int expected)
    {
        var actual = Solution.IsPrefixOfWord(sentence, searchWord);
        Assert.Equal(expected, actual);
    }
}