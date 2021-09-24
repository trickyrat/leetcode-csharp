// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class CheckInclusionUnitTest
    {
        [Fact]
        public void Test_Should_Return_True()
        {
            string s1 = "ab", s2 = "eidbaooo";
            bool actual = Solution.CheckInclusion(s1, s2);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Should_Return_False()
        {
            string s1 = "ab", s2 = "eidboaoo";
            bool actual = Solution.CheckInclusion(s1, s2);
            bool expected = false;
            Assert.Equal(expected, actual);
        }
    }
}
