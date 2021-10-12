// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class MinimumTotalUnitTest
    {
        [Fact]
        public void Test()
        {
            IList<IList<int>> data = new List<IList<int>>
            {
                new List<int>{ 2},
                new List<int>{ 3,4},
                new List<int>{ 6,5,7},
                new List<int>{ 4,1,8,3},
            };
            int actual = Solution.MinimumTotal(data);
            int expected = 11;
            Assert.Equal(expected, actual);
        }
    }
}
