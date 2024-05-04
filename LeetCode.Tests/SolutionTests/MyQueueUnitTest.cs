﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MyQueueUnitTest
{
    [Fact]
    public void OnlyPushAndPop()
    {
        var queue = new MyQueue();
        queue.Push(1);
        var actual = queue.Pop();
        var actualResult = queue.Empty();

        Assert.Equal(1, actual);
        Assert.True(actualResult);
    }
}
