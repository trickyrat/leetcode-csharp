// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class RandomizedSetUnitTest
{
    [Fact]
    public void Test()
    {
        var randomizedSet = new RandomizedSet();
        Assert.True(randomizedSet.Insert(1));
        Assert.False(randomizedSet.Remove(2));
        Assert.True(randomizedSet.Insert(2));
        Assert.Contains(randomizedSet.GetRandom(), new List<int> { 1, 2 });
        Assert.True(randomizedSet.Remove(1));
        Assert.False(randomizedSet.Insert(2));
        Assert.Equal(2, randomizedSet.GetRandom());
    }

}