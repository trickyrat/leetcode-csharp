// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class ReverseStringUnitTest
    {
        [Fact]
        public void Test1()
        {
            char[] actual = new char[] { 'h', 'e', 'l', 'l', 'o' };
            Solution.ReverseString(actual);
            char[] expected = new char[] { 'o', 'l', 'l', 'e', 'h' };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            char[] actual = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            Solution.ReverseString(actual);
            char[] expected = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' };
            Assert.Equal(expected, actual);
        }
    }
}
