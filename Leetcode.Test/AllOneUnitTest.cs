// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Leetcode.Test
{
    public class AllOneUnitTest
    {
        [Fact]
        public void SingleTest()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("hello");
            string actualMaxKey1 = allOne.GetMaxKey();
            string actualMinKey1 = allOne.GetMinKey();
            Assert.Equal("hello", actualMaxKey1);
            Assert.Equal("hello", actualMinKey1);
            allOne.Inc("leet");
            string actualMaxKey2 = allOne.GetMaxKey();
            string actualMinKey2 = allOne.GetMinKey();
            Assert.Equal("hello", actualMaxKey2);
            Assert.Equal("leet", actualMinKey2);
        }

    }
}