// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Leetcode.Test
{
    public class IntToRomanUnitTest
    {

        [Theory]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void MultipleDataTest(int num, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.IntToRoman(num);
            Assert.Equal(expected, actual);
        }

    }
}