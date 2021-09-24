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
    public class NumMatrixUnitTest
    {
        private int[][] matrix =
                        {
                new int[5]{ 3,0,1,4,2},
                new int[5]{ 5,6,3,2,1},
                new int[5]{ 1,2,0,1,5},
                new int[5]{ 4,1,0,1,7},
                new int[5]{ 1,0,3,0,5},
            };

        [Fact]
        public void TestMethod1()
        {
            NumMatrix nm = new NumMatrix(matrix);
            int actual = nm.SumRange(2, 1, 4, 3);
            int expected = 8;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMethod2()
        {
            NumMatrix nm = new NumMatrix(matrix);
            int actual = nm.SumRange(1, 1, 2, 2);
            int expected = 11;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMethod3()
        {
            NumMatrix nm = new NumMatrix(matrix);
            int actual = nm.SumRange(1, 2, 2, 4);
            int expected = 12;
            Assert.Equal(expected, actual);
        }
    }
}
