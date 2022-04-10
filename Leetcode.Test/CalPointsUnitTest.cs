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
    public class CalPointsUnitTest
    {
        [Theory]
        [InlineData(new string[] { "5", "2", "C", "D", "+" }, 30)]
        [InlineData(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)]
        [InlineData(new string[] { "1" }, 1)]
        public void Test(string[] input, int expected)
        {
            int actual = Solution.CalPoints(input);
            Assert.Equal(expected, actual);
        }
    }
}
