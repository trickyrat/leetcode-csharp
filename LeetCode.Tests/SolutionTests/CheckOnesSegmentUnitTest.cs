// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;
public class CheckOnesSegmentUnitTest
{
    [Theory]
    [InlineData("1001", false)]
    [InlineData("110", true)]
    public void MultipleDataTest(string s, bool expected)
    {
        var actual = Solution.CheckOnesSegment(s);
        Assert.Equal(expected, actual);
    }
}

