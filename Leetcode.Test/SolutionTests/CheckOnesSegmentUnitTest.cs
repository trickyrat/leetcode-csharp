// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class CheckOnesSegmentUnitTest
{
    private readonly Solution _solution;

    public CheckOnesSegmentUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("1001", false)]
    [InlineData("110", true)]
    public void MultipleDataTest(string s, bool expected)
    {
        var actual = _solution.CheckOnesSegment(s);
        Assert.Equal(expected, actual);
    }
}

