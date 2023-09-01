// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Linq;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class SimplifiedFractionsUnitTest
{
    [Theory]
    [InlineData(2, new string[] { "1/2" })]
    public void Test(int n, string[] expected)
    {

        var list = Solution.SimplifiedFractions(n);
        var actual = list.ToArray();
        Assert.Equal(expected, actual);
    }
}
