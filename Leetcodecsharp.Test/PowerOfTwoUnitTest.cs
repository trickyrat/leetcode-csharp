// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class PowerOfTwoUnitTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(16)]
        [InlineData(4)]
        public void Test(int num)
        {
            Assert.True(Solution.IsPowerOfTwo(num));
        }


        [Theory]
        [InlineData(3)]
        public void Test2(int num)
        {
            Assert.False(Solution.IsPowerOfTwo(num));
        }
    }
}
