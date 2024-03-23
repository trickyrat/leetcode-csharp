// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ReverseStringUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' }
        ];
        yield return
        [
            new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(char[] actual, char[] expected)
    {
        Solution.ReverseString(actual);
        Assert.Equal(expected, actual);
    }
}