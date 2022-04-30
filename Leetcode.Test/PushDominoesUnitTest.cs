﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class PushDominoesUnitTest
    {
        [Theory]
        [InlineData("RR.L", "RR.L")]
        [InlineData(".L.R...LR..L..", "LL.RR.LLRRLL..")]
        public void Test(string input, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.PushDominoes(input);
            Assert.Equal(expected, actual);
        }
    }
}