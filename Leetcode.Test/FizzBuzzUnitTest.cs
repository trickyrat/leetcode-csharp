// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test
{
    public class FizzBuzzUnitTest
    {
        [Theory]
        [InlineData(3, new string[] { "1", "2", "Fizz" })]
        [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void Test(int n, IList<string> expected)
        {
            Solution solution = new Solution();
            IList<string> actual = solution.FizzBuzz(n);
            Assert.Equal(expected, actual);
        }
    }
}
