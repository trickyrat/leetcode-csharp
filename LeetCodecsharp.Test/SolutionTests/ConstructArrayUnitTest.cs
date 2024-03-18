// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ConstructArrayUnitTest
{
    public static TheoryData<int, int, int[]> Data
    {
        get
        {
            var data = new TheoryData<int, int, int[]>
            {
                { 3, 1, [1, 2, 3] },
                { 3, 2, [1, 3, 2] }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int n, int k, int[] expected)
    {
        var actual = Solution.ConstructArray(n, k);
        Assert.Equal(expected, actual);
    }
}