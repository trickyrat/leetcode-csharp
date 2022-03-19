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
    public class SearchMatrixUnitTest
    {
        [Fact]
        public void Test_Target_Exists()
        {
            int[][] matrix = new int[3][]
            {
                new int[] {1,3,5,7 },
                new int[] {10,11,16,20 },
                new int[] {23,30,34,60 }
            };
            bool actual = Solution.SearchMatrix(matrix, 3);
            Assert.True(actual);
        }

        [Fact]
        public void Test_Target_Not_Exists()
        {
            int[][] matrix = new int[3][]
            {
                new int[] {1,3,5,7 },
                new int[] {10,11,16,20 },
                new int[] {23,30,34,60 }
            };
            bool actual = Solution.SearchMatrix(matrix, 13);
            Assert.False(actual);
        }
    }
}
