﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class OneEditAwayUnitTest
    {
        private readonly Solution _solution;

        public OneEditAwayUnitTest()
        {
            _solution = new Solution();
        }


        [Theory]
        [InlineData("pale", "ple", true)]
        [InlineData("pales", "pal", false)]
        public void MultipleDataTest(string first, string second, bool expected)
        {
            bool actual = _solution.OneEditAway(first, second);
            Assert.Equal(expected, actual);
        }
    }
}