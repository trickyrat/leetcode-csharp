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
    public class OrangeRottingUnitTest
    {
        [Fact]
        public void Test()
        {
            int[][] grid = new int[3][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 }
            };
            int actual = Solution.OrangeRotting(grid);
            int expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZeroResult_Test()
        {
            int[][] grid = new int[1][]
            {
                new int[] { 0, 2 }
            };
            int actual = Solution.OrangeRotting(grid);
            int expected = 0;
            Assert.Equal(expected, actual);
        }
    }
}
