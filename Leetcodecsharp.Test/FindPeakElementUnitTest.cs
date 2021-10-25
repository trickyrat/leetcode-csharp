// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class FindPeakElementUnitTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, 2)]
        [InlineData(new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5)]
        public void Test(int[] arr, int expected)
        {
            int actual = Solution.FindPeakElement(arr);
            Assert.Equal(expected, actual);
        }
    }
}
