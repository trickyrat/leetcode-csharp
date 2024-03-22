// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using LeetCode.DataStructure;
using Xunit;

namespace LeetCode.Tests.SolutionTests
{
    public class SumRootToLeafUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return
            [
                Util.CreateTreeNode([1, 0, 1, 0, 1, 0, 1]),
                22
            ];
            yield return
            [
                Util.CreateTreeNode([0]),
                0
            ];
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(TreeNode root, int expected)
        {
            var actual = Solution.SumRootToLeaf(root);
            Assert.Equal(expected, actual);
        }
    }
}