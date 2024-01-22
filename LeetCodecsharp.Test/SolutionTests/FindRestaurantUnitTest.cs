// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FindRestaurantUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" },
            new[] { "Shogun" }
        ];

        yield return
        [
            new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new[] { "KFC", "Shogun", "Burger King" }, new[] { "Shogun" }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string[] list1, string[] list2, string[] expect)
    {
        var actual = Solution.FindRestaurant(list1, list2);
        Assert.Equal(expect, actual);
    }
}