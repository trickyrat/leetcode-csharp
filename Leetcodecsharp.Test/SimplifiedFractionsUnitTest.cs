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
    public class SimplifiedFractionsUnitTest
    {
        [Theory]
        [InlineData(2, new string[] {"1/2"})]
        public void Test(int n, string[] expected)
        {
            IList<string> list = Solution.SimplifiedFractions(n);
            var actual = list.ToArray();
            Assert.Equal(expected, actual);
        }
    }
}
