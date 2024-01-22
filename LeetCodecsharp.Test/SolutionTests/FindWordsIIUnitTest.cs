// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class FindWordsIIUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return
            [
                new char[][]
                {
                    ['o', 'a', 'a', 'n'],
                    ['e', 't', 'a', 'e'],
                    ['i', 'h', 'k', 'r'],
                    ['i', 'f', 'l', 'v'],
                },
                new[]{ "oath", "pea", "eat", "rain" },
                new[]{ "oath", "eat" }
            ];
            yield return
            [
                new char[][]
                {
                    ['a', 'b'],
                    ['c', 'd']
                },
                new []{ "abcb" },
                Array.Empty<string>()
            ];
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