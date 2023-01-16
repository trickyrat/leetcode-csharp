// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ReverseOnlyLettersUnitTest
{
    private readonly Solution _solution;
    public ReverseOnlyLettersUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("ab-cd", "dc-ba")]
    [InlineData("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
    [InlineData("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
    public void Test(string s, string expected)
    {

        var actual = _solution.ReverseOnlyLetters(s);
        Assert.Equal(expected, actual);
    }
}
