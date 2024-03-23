// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ValidateStackSequencesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 2, 1 }, true
        ];
        yield return
        [
            new[] { 1, 2, 3, 4, 5 }, new[] { 4, 3, 5, 1, 2 }, false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] pushed, int[] popped, bool expected)
    {
        var actual = Solution.ValidateStackSequences(pushed, popped);
        Assert.Equal(expected, actual);
    }
}