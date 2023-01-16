// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class TitleToNumberUnitTest
    {
        private readonly Solution _solution;

        public TitleToNumberUnitTest()
        {
            _solution = new Solution();
        }


        [Theory]
        [InlineData("A", 1)]
        [InlineData("AB", 28)]
        [InlineData("ZY", 701)]
        public void MultipleDataTest(string columnTitle, int expected)
        {
            var actual = _solution.TitleToNumber(columnTitle);
            Assert.Equal(expected, actual);
        }

    }
}