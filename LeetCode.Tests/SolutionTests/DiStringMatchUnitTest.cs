// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class DiStringMatchUnitTest
{
    public static TheoryData<string, int[]> Data =>
        new()
        {
            { "IDID", [0, 4, 1, 3, 2] },
            { "III", [0, 1, 2, 3] },
            { "DDI", [3, 2, 0, 1] },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(string s, int[] expected)
    {
        var actual = Solution.DIStringMatch(s);
        Assert.Equal(expected, actual);
    }
}