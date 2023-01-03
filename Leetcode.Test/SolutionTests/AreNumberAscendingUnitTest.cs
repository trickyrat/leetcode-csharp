// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class AreNumberAscendingUnitTest
{
    private readonly Solution _solution;

    public AreNumberAscendingUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("1 box has 3 blue 4 red 6 green and 12 yellow marbles", true)]
    [InlineData("hello world 5 x 5", false)]
    [InlineData("sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s", false)]
    public void MultipleDataTest(string s, bool expected)
    {
        var actual = _solution.AreNumberAscending(s);
        Assert.Equal(expected, actual);
    }

}