// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FinalValueAfterOperationsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "--X", "X++", "X++" }, 1
        ];
        yield return
        [
            new[] { "++X", "++X", "X++" }, 3
        ];
        yield return
        [
            new[] { "X++", "++X", "--X", "X--" }, 0
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string[] operations, int expected)
    {
        var actual = Solution.FinalValueAfterOperations(operations);
        Assert.Equal(expected, actual);
    }
}