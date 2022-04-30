﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class ToGoatLatinUnitTest
    {


        [Theory]
        [InlineData("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [InlineData("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
        public void MultipleDataTest(string sentence, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.ToGoatLatin(sentence);
            Assert.Equal(expected, actual);
        }
    }
}