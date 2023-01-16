// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.InterviewSolutionTests;

public class FindClosestUnitTest
{

    private readonly InterviewSolution _solution;

    public FindClosestUnitTest()
    {
        _solution = new InterviewSolution();
    }

    [Theory]
    [InlineData(new string[] { "I", "am", "a", "student", "from", "a", "university", "in", "a", "city" }, "a", "student", 1)]
    public void MultipleDataTest(string[] words, string word1, string word2, int expected)
    {
        var actual = _solution.FindClosest(words, word1, word2);
        Assert.Equal(expected, actual);
    }
}