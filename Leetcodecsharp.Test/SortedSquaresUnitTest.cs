// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class SortedSquaresUnitTest
    {
        [Fact]
        public void Test_Input_Two_Types_Numbers_Should_Ok()
        {
            int[] actual = Solution.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            int[] expected = new int[] { 0, 1, 9, 16, 100 };
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void Test_Input_All_Positive_Numbers_Should_Ok()
        {
            int[] actual = Solution.SortedSquares(new int[] { 0, 3, 4, 6, 10 });
            int[] expected = new int[] { 0, 9, 16, 36, 100 };
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_Input_All_Negative_Numbers_Should_Ok()
        {
            int[] actual = Solution.SortedSquares(new int[] { -10, -6, -5, -4, -3 });
            int[] expected = new int[] { 9, 16, 25, 36, 100 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Opposite_Number_Should_Ok()
        {
            int[] actual = Solution.SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            int[] expected = new int[] { 4, 9, 9, 49, 121 };
            Assert.Equal(expected, actual);
        }
    }
}
