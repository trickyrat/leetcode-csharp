// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FindSubstringInWraparoundStringUnitTest
{
    [Theory]
    [InlineData("a", 1)]
    [InlineData("cac", 2)]
    [InlineData("zab", 6)]
    public void Test(string p, int expected)
    {
        var actual = Solution.FindSubstringInWraparoundString(p);
        Assert.Equal(expected, actual);
    }
}