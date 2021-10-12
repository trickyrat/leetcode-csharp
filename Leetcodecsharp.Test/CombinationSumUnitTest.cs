// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class CombinationSumUnitTest
    {
        [Fact]
        public void Test1()
        {
            var actual = Solution.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int>{ 7},
                new List<int>{ 2,2,3},
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var actual = Solution.CombinationSum(new int[] { 2 }, 1);
            IList<IList<int>> expected = new List<IList<int>>();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            var actual = Solution.CombinationSum(new int[] { 2, 3, 5 }, 8);
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int>{ 3,5},
                new List<int>{ 2,3,3},
                new List<int>{ 2,2,2,2},
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            var actual = Solution.CombinationSum(new int[] { 1 }, 1);
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int>{ 1},
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            var actual = Solution.CombinationSum(new int[] { 1 }, 2);
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int>{ 1, 1},
            };
            Assert.Equal(expected, actual);
        }
    }
}
