// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class MagicIndexUnitTest
    {
        [Fact]
        public void MagicIndexTest1()
        {
            int[] nums = { 0, 1, 2, 3, 4 };
            int actual = Solution.FindMagicIndex(nums);
            int expected = 0;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MagicIndexTest2()
        {
            int[] nums = { 0, 1, 3, 3, 4 };
            int actual = Solution.FindMagicIndex(nums);
            int expected = 0;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MagicIndexTest3()
        {
            int[] nums = { 0, 2, 3, 3, 4 };
            int actual = Solution.FindMagicIndex(nums);
            int expected = 0;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void MagicIndexTest4()
        {
            int[] nums = { 1, 2, 2, 3, 4 };
            int actual = Solution.FindMagicIndex(nums);
            int expected = 2;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MagicIndexTest5()
        {
            int[] nums = { 1, 2, 3, 4, 4 };
            int actual = Solution.FindMagicIndex(nums);
            int expected = 4;

            Assert.Equal(expected, actual);
        }
    }
}
