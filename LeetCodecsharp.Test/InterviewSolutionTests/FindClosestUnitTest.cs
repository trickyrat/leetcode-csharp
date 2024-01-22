// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.InterviewSolutionTests;

public class FindClosestUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "I", "am", "a", "student", "from", "a", "university", "in", "a", "city" }, "a", "student", 1
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string[] words, string word1, string word2, int expected)
    {
        var actual = InterviewSolution.FindClosest(words, word1, word2);
        Assert.Equal(expected, actual);
    }
}