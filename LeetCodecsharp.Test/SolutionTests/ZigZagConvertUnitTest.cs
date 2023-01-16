// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ZigZagConvertUnitTest
{
    private readonly Solution _solution;

    public ZigZagConvertUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    public void Test(string s, int numRows, string expected)
    {
        var actual = _solution.Convert(s, numRows);
        Assert.Equal(expected, actual);
    }
}