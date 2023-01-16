// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.InterviewSolutionTests;

public class OneEditAwayUnitTest
{
    private readonly InterviewSolution _solution;

    public OneEditAwayUnitTest()
    {
        _solution = new InterviewSolution();
    }


    [Theory]
    [InlineData("pale", "ple", true)]
    [InlineData("pales", "pal", false)]
    public void MultipleDataTest(string first, string second, bool expected)
    {
        var actual = _solution.OneEditAway(first, second);
        Assert.Equal(expected, actual);
    }
}