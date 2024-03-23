// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class LetterCasePermutationUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            "a1b2", new[] { "a1b2", "A1b2", "a1B2", "A1B2" }
        ];

        yield return
        [
            "3z4", new[] { "3z4", "3Z4" }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string input, string[] expected)
    {
        var actual = Solution.LetterCasePermutation(input);
        Assert.Equal(expected, actual);
    }
}