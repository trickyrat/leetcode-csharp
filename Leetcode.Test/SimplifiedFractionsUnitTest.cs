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
    public class SimplifiedFractionsUnitTest
    {
        [Theory]
        [InlineData(2, new string[] { "1/2" })]
        public void Test(int n, string[] expected)
        {
            Solution solution = new Solution();
            IList<string> list = solution.SimplifiedFractions(n);
            var actual = list.ToArray();
            Assert.Equal(expected, actual);
        }
    }
}
