// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class HammingWeightUnitTest
    {
        [Fact]
        public void Test()
        {
            int actual = Solution.HammingWeight(11);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int actual = Solution.HammingWeight(128);
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int actual = Solution.HammingWeight(4294967293);
            int expected = 31;
            Assert.Equal(expected, actual);
        }
    }
}
