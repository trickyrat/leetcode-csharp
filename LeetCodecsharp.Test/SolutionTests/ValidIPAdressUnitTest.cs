// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;


public class ValidIPAdressUnitTest
{
    [Theory]
    [InlineData("172.16.254.1", "IPv4")]
    [InlineData("2001:0db8:85a3:0:0:8A2E:0370:7334", "IPv6")]
    [InlineData("256.256.256.256", "Neither")]
    [InlineData("056.256.256.256", "Neither")]
    [InlineData("0.016.056.056", "Neither")]
    [InlineData("12.12.12.12.12", "Neither")]
    [InlineData("12.12..12.12", "Neither")]
    [InlineData("0az:12:12:12:12:123:23:32", "Neither")]
    [InlineData("0az:12:12:12:12:123", "Neither")]
    [InlineData("0a:12:12:12:12:123:23:32:11", "Neither")]
    [InlineData("0a:12:12:12::123:23:0A", "Neither")]
    public void Test(string address, string expected)
    {
        var actual = Solution.ValidIPAddress(address);
        Assert.Equal(expected, actual);
    }

}
