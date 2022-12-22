// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class FindRestaurantUnitTest
{
    private readonly Solution _solution;

    public FindRestaurantUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" }, new string[] { "Shogun" })]
    [InlineData(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "KFC", "Shogun", "Burger King" }, new string[] { "Shogun" })]
    public void Test(string[] list1, string[] list2, string[] expect)
    {

        var actual = _solution.FindRestaurant(list1, list2);
        Assert.Equal(expect, actual);
    }
}