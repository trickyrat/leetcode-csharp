// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.InterviewSolutionTests;
public class GetKthMagicNumberUnitTest
{
    private readonly InterviewSolution _solution;

    public GetKthMagicNumberUnitTest()
    {
        _solution = new InterviewSolution();
    }


    [Theory]
    [InlineData(5, 9)]
    public void MultipleDataTest(int k, int expected)
    {
        var actual = _solution.GetKthMagicNumber(k);
        Assert.Equal(expected, actual);
    }
}

