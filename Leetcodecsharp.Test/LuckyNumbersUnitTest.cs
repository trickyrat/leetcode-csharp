// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Leetcodecsharp.Test
{
    public class LuckyNumbersUnitTest
    {
        [Fact]
        public void Test1()
        {
            int[][] matrix = new int[][]
            {
                new int[] { 3, 7, 8 },
                new int[] { 9, 11, 13 },
                new int[] { 15, 16, 17 },
            };
            List<int> expected = new List<int> { 15 };
            List<int> actual = Solution.LuckyNumbers(matrix).ToList();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[][] matrix = new int[][]
            {
                new int[] { 1, 10, 4, 2 },
                new int[] { 9, 3, 8, 7 },
                new int[] { 15, 16, 17, 12 },
            };
            List<int> expected = new List<int> { 12 };
            List<int> actual = Solution.LuckyNumbers(matrix).ToList();
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test3()
        {
            int[][] matrix = new int[][]
            {
                new int[] { 7, 8 },
                new int[] { 1, 2 },
            };
            List<int> expected = new List<int> { 7 };
            List<int> actual = Solution.LuckyNumbers(matrix).ToList();
            Assert.Equal(expected, actual);
        }
    }
}
