// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.InterviewSolutionTests;
public class GetKthMagicNumberUnitTest
{
    [Theory]
    [InlineData(5, 9)]
    public void MultipleDataTest(int k, int expected)
    {
        var actual = InterviewSolution.GetKthMagicNumber(k);
        Assert.Equal(expected, actual);
    }
}

