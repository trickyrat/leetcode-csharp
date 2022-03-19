// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class OptimalDivisionUnitTest
    {
        [Fact]
        public void SingleTest()
        {
            int[] nums = { 1000, 100, 10, 2 };
            string actual = Solution.OptimalDivision(nums);
            string expected = "1000/(100/10/2)";
            Assert.Equal(actual, expected);
        }

    }
}