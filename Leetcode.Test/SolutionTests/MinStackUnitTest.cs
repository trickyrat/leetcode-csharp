// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class MinStackUnitTest
{
    [Fact]
    public void Test()
    {
        var min = new MinStack();
        min.Push(-2);
        min.Push(0);
        min.Push(-3);
        Assert.Equal(-3, min.GetMin());
        min.Pop();
        Assert.Equal(0, min.Top());
        Assert.Equal(-2, min.GetMin());
    }
}
