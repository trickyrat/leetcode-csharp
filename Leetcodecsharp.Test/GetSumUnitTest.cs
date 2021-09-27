// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class GetSumUnitTest
    {
        [Fact]
        public void Test_Without_Carry_Should_OK()
        {
            int actual = Solution.GetSum(1, 2);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_With_A_Carry_Should_OK()
        {
            int actual = Solution.GetSum(7, 3);
            int expected = 10;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_One_Negative_Integer_Should_OK()
        {
            int actual = Solution.GetSum(1, -2);
            int expected = -1;
            Assert.Equal(expected, actual);
        }
    }
}
