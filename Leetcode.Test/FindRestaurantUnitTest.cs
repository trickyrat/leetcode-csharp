// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class FindRestaurantUnitTest
{
    [Theory]
    [InlineData(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" }, new string[] { "Shogun" })]
    [InlineData(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "KFC", "Shogun", "Burger King" }, new string[] { "Shogun" })]
    public void Test(string[] list1, string[] list2, string[] expect)
    {
        Solution solution = new Solution();
        string[] actual = solution.FindRestaurant(list1, list2);
        Assert.Equal(expect, actual);
    }
}