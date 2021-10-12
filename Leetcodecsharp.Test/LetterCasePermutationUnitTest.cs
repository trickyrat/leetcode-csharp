// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class LetterCasePermutationUnitTest
    {
        [Fact]
        public void Test()
        {
            List<string> actual = Solution.LetterCasePermutation("a1b2");
            List<string> expected = new List<string>
            {
                "a1b2","A1b2","a1B2","A1B2"
            };
            Assert.Equal(expected, actual);
        }
    }
}
