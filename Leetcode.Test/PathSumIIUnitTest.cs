// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test
{
    public class PathSumIIUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
               Utilities.CreateTreeNodeWithBFS(new List<int?>{1,2,3 }),
               5,
               new List<List<int>>()
            };
            yield return new object[]
            {
                Utilities.CreateTreeNodeWithBFS(new List<int?>{5,4,8,11,null,13,4,7,2,null,null,5,1 }),
                22,
                new List<List<int>>()
                {
                    new List<int>{ 5, 4, 11, 2 },
                    new List<int>{ 5, 8, 4, 5 },
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(TreeNode input, int targetNum, IList<List<int>> expected)
        {
            Solution solution = new Solution();
            IList<IList<int>> actual = solution.PathSum(input, targetNum);
            Assert.Equal(expected, actual);
        }
    }
}
