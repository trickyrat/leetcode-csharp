// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class LongestCommonPrefixUnitTest
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void MultipleDataTest(string[] strs, string expected)
    {

        var actual = Solution.LongestCommonPrefix(strs);
        Assert.Equal(expected, actual);
    }

}