// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class IntToRomanUnitTest
{
    [Theory]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(9, "IX")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    public void MultipleDataTest(int num, string expected)
    {

        var actual = Solution.IntToRoman(num);
        Assert.Equal(expected, actual);
    }

}