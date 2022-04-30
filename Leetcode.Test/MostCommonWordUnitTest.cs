// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class MostCommonWordUnitTest
{
    [Theory]
    [InlineData("Bob hit a ball, the hit BALL flew far after it was hit.", new string[]{"hit"}, "ball")]
    public void Test(string paragraph, string[] banned, string expected)
    {
        Solution solution = new Solution();
        string actual = solution.MostCommonWord(paragraph, banned);
        Assert.Equal(expected, actual);
    }
    
}