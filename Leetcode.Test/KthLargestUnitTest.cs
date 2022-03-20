// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class KthLargestUnitTest
{
    [Fact]
    public void Test1()
    {
        int[] nums = new int[4] { 4, 5, 8, 2 };
        KthLargest kthLargest = new KthLargest(3, nums);
        int actual = kthLargest.Add(3);
        int expected = 4;
        Assert.Equal(expected, actual);

        actual = kthLargest.Add(5);
        expected = 5;
        Assert.Equal(expected, actual);

        actual = kthLargest.Add(10);
        expected = 5;
        Assert.Equal(expected, actual);


        actual = kthLargest.Add(9);
        expected = 8;
        Assert.Equal(expected, actual);

        actual = kthLargest.Add(4);
        expected = 8;
        Assert.Equal(expected, actual);
    }
}
