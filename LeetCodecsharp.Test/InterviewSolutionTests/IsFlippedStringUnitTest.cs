// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.InterviewSolutionTests;
public class IsFlippedStringUnitTest
{
    private readonly InterviewSolution _solution;

    public IsFlippedStringUnitTest()
    {
        _solution = new InterviewSolution();
    }


    [Theory]
    [InlineData("waterbottle", "erbottlewat", true)]
    [InlineData("aa", "aba", false)]
    public void MultipleDataTest(string s1, string s2, bool expected)
    {
        var actual = _solution.IsFlippedString(s1, s2);
        Assert.Equal(expected, actual);
    }
}

