// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class AllOneUnitTest
{
    [Fact]
    public void SingleTest()
    {
        var allOne = new AllOne();
        allOne.Inc("hello");
        allOne.Inc("hello");
        var actualMaxKey1 = allOne.GetMaxKey();
        var actualMinKey1 = allOne.GetMinKey();
        Assert.Equal("hello", actualMaxKey1);
        Assert.Equal("hello", actualMinKey1);
        allOne.Inc("leet");
        var actualMaxKey2 = allOne.GetMaxKey();
        var actualMinKey2 = allOne.GetMinKey();
        Assert.Equal("hello", actualMaxKey2);
        Assert.Equal("leet", actualMinKey2);
    }



    [Fact]
    public void SingleTest2()
    {
        var allOne = new AllOne();
        allOne.Inc("a");
        allOne.Inc("b");
        allOne.Inc("b");
        allOne.Inc("b");
        allOne.Inc("b");
        allOne.Dec("b");
        allOne.Dec("b");
        var actualMaxKey1 = allOne.GetMaxKey();
        var actualMinKey1 = allOne.GetMinKey();
        Assert.Equal("b", actualMaxKey1);
        Assert.Equal("a", actualMinKey1);
    }

}