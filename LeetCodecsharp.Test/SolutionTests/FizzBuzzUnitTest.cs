// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FizzBuzzUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            3, new[] { "1", "2", "Fizz" }
        ];

        yield return
        [
            5, new[] { "1", "2", "Fizz", "4", "Buzz" }
        ];

        yield return
        [
            15,
            new[]
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
            }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int n, IList<string> expected)
    {
        var actual = Solution.FizzBuzz(n);
        Assert.Equal(expected, actual);
    }
}