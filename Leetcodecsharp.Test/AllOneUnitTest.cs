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



        [Fact]
        public void SingleTest2()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("a");
            allOne.Inc("b");
            allOne.Inc("b");
            allOne.Inc("b");
            allOne.Inc("b");
            allOne.Dec("b");
            allOne.Dec("b");
            string actualMaxKey1 = allOne.GetMaxKey();
            string actualMinKey1 = allOne.GetMinKey();
            Assert.Equal("b", actualMaxKey1);
            Assert.Equal("a", actualMinKey1);
        }

    }
}