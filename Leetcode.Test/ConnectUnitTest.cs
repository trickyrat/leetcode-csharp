// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test
{
    public class ConnectUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new BinaryTreeNode(),
                new BinaryTreeNode()
            };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(BinaryTreeNode input, BinaryTreeNode expected)
        {
            Solution solution = new Solution();
            var actual = solution.Connect(input);
            //Assert.Equal(expected, actual);
        }
    }
}
