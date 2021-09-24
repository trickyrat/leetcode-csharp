// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class TwoSumIIUnitTest
    {
        [Fact]
        public void Test1()
        {
            int[] input = { 2, 7, 11, 15 };
            int[] actual = Solution.TwoSumII(input, 9);
            int[] expected = { 1, 2 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] input = { 2, 3, 4 };
            int[] actual = Solution.TwoSumII(input, 6);
            int[] expected = { 1, 3 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] input = { -1, 0 };
            int[] actual = Solution.TwoSumII(input, -1);
            int[] expected = { 1, 2 };
            Assert.Equal(expected, actual);
        }
    }
}
