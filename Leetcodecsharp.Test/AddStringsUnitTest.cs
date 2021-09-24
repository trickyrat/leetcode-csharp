// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class AddStringsUnitTest
    {
        [Fact]
        public void AddStringsTest1()
        {
            string num1 = "1345";
            string num2 = "8656";
            string actual = Solution.AddStrings(num1, num2);
            string expected = "10001";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddStringsTest2()
        {
            string num1 = "245";
            string num2 = "356";
            string actual = Solution.AddStrings(num1, num2);
            string expected = "601";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddStringsTest3()
        {
            string num1 = "999";
            string num2 = "1231";
            string actual = Solution.AddStrings(num1, num2);
            string expected = "2230";

            Assert.Equal(expected, actual);
        }
    }
}
