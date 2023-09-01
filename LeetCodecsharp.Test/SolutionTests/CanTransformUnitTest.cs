// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class CanTransformUnitTest
{
    [Theory]
    [InlineData("RXXLRXRXL", "XRLXXRRLX", true)]
    [InlineData("R", "L", false)]
    public void MultipleDataTest(string start, string end, bool expected)
    {
        var actual = Solution.CanTransform(start, end);
        Assert.Equal(expected, actual);
    }
}

