// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MyQueueUnitTest
{
    [Fact]
    public void OnlyPushAndPop()
    {
        var queue = new MyQueue();
        queue.Push(1);
        var actual = queue.Pop();
        var booleanActual = queue.Empty();

        var expected = 1;
        var booleanExpected = true;
        Assert.Equal(expected, actual);
        Assert.Equal(booleanExpected, booleanActual);
    }
}
