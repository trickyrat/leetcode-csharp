// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class FindWordsIIUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new char[][]
                {
                    new char[]{ 'o', 'a', 'a', 'n' },
                    new char[]{ 'e', 't', 'a', 'e' },
                    new char[]{ 'i', 'h', 'k', 'r' },
                    new char[]{ 'i', 'f', 'l', 'v' },
                },
                new string[]{ "oath", "pea", "eat", "rain" },
                new string[]{ "oath", "eat" }
            };
            yield return new object[]
          {
                new char[][]
                {
                    new char[]{ 'a', 'b' },
                    new char[]{ 'c', 'd' }
                },
                new string[]{ "abcb" },
                new string[]{ }
          };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(char[][] board, string[] words, IList<string> expected)
        {
            var actual = Solution.FindWords(board, words);
            Assert.Equal(expected, actual);
        }
    }
}