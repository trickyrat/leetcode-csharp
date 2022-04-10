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
    public class FindDiagonalOrderUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new int[][] 
                {
                    new int[]{ 1, 2, 3 },
                    new int[]{ 4, 5, 6 },
                    new int[]{ 7, 8, 9 },
                },
                new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }
            };
            yield return new object[]
            {
                new int[][]
                {
                    new int[]{ 1, 2 },
                    new int[]{ 3, 4 },
                },
                new int[] { 1, 2, 3, 4 }
            };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(int[][] matrix, int[] expected)
        {
            int[] actual = Solution.FindDiagonalOrder(matrix);
            Assert.Equal(expected, actual);
        }
    }
}