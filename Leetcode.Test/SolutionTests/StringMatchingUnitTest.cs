// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class StringMatchingUnitTest
{
    private readonly Solution _solution;

    public StringMatchingUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new string[] { "mass", "as", "hero", "superhero" }, new string[] { "as", "hero" })]
    [InlineData(new string[] { "leetcode", "et", "code" }, new string[] { "et", "code" })]
    [InlineData(new string[] { "blue", "green", "bu" }, new string[] { })]
    public void MultipleDataTest(string[] words, IList<string> expected)
    {
        var actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }
}

