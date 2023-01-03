// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class StockSpannerUnitTest
{
    private readonly StockSpanner _stockSpanner;

    public StockSpannerUnitTest()
    {
        _stockSpanner = new StockSpanner();
    }

    [Fact]
    public void MultipleDataTest()
    {
        Assert.Equal(1, _stockSpanner.Next(100));
        Assert.Equal(1, _stockSpanner.Next(80));
        Assert.Equal(1, _stockSpanner.Next(60));
        Assert.Equal(2, _stockSpanner.Next(70));
        Assert.Equal(1, _stockSpanner.Next(60));
        Assert.Equal(4, _stockSpanner.Next(75));
        Assert.Equal(6, _stockSpanner.Next(85));
    }
}

