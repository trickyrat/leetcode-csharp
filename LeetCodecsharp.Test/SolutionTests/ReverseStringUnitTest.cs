// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ReverseStringUnitTest
{
    private readonly Solution _solution;

    public ReverseStringUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public void Test(char[] actual, char[] expected)
    {

        _solution.ReverseString(actual);
        Assert.Equal(expected, actual);
    }
}
