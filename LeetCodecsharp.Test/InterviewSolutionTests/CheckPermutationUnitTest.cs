// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.InterviewSolutionTests;
public class CheckPermutationUnitTest
{
    [Theory]
    [InlineData("abc", "bca", true)]
    [InlineData("abc", "bad", false)]
    public void MultipleDataTest(string s1, string s2, bool expected)
    {
        var actual = InterviewSolution.CheckPermutation(s1, s2);
        Assert.Equal(expected, actual);
    }
}

