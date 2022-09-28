// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class SimplifiedFractionsUnitTest
{
    private readonly Solution _solution;
    public SimplifiedFractionsUnitTest()
    {
        _solution = new Solution();

    }
    [Theory]
    [InlineData(2, new string[] { "1/2" })]
    public void Test(int n, string[] expected)
    {

        var list = _solution.SimplifiedFractions(n);
        var actual = list.ToArray();
        Assert.Equal(expected, actual);
    }
}
