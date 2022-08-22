// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test;
public class FindSubstringUnitTest
{
    private readonly Solution _solution;

    public FindSubstringUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("barfoothefoobarman", new string[] { "foo", "bar" }, new int[] { 0, 9 })]
    [InlineData("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "word" }, new int[] { })]
    [InlineData("barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" }, new int[] { 6, 9, 12 })]
    public void MultipleDataTest(string s, string[] words, IList<int> expected)
    {
        var actual = _solution.FindSubstring(s, words);
        Assert.Equal(expected, actual);
    }
}

