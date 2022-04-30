// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test
{
    public class CombinationSumUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new CombinationSumData
                {
                    Candidates = new int[] { 2, 3, 6, 7 },
                    Target = 7,
                    Expected = new List<IList<int>>
                    {
                        new List<int>{ 7 },
                        new List<int>{ 2, 2, 3},
                    }
                }
            };
            yield return new object[]
            {
                new CombinationSumData
                {
                    Candidates = new int[] { 2 },
                    Target = 1,
                    Expected = new List<IList<int>>()
                }
            };
            yield return new object[]
            {
                new CombinationSumData
                {
                    Candidates = new int[] { 2, 3, 5 },
                    Target = 8,
                    Expected = new List<IList<int>>
                    {
                        new List<int>{ 3, 5 },
                        new List<int>{ 2, 3, 3 },
                        new List<int>{ 2, 2, 2, 2 },
                    }
                }
            };
            yield return new object[]
            {
                new CombinationSumData
                {
                    Candidates = new int[] { 1 },
                    Target = 1,
                    Expected = new List<IList<int>>
                    {
                        new List<int>{ 1 },
                    }
                }
            };
            yield return new object[]
            {
                new CombinationSumData
                {
                    Candidates = new int[] { 1 },
                    Target = 2,
                    Expected = new List<IList<int>>
                    {
                        new List<int>{ 1, 1 },
                    }
                }
            };
        }

        internal class CombinationSumData
        {
            public int[] Candidates { get; set; }
            public int Target { get; set; }

            public IList<IList<int>> Expected { get; set; }

        }


        [Theory]
        [MemberData(nameof(GetData))]
        private void Test1(CombinationSumData input)
        {
            Solution solution = new Solution();
            var actual = solution.CombinationSum(input.Candidates, input.Target);
            Assert.Equal(input.Expected, actual);
        }
    }
}
