// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class SumRootToLeafUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                Util.CreateTreeNode(new List<int?>{ 1,0,1,0,1,0,1}),
                22
            };
            yield return new object[]
            {
                Util.CreateTreeNode(new List<int?>{ 0 }),
                0
            };
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