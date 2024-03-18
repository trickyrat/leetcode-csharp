// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using LeetCodecsharp.DataStructure;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ConstructMaximumBinaryTreeUnitTest
{
    public static TheoryData<int[], TreeNode> Data
    {
        get
        {
            var data = new TheoryData<int[], TreeNode>
            {
                {
                    [3, 2, 1, 6, 0, 5],
                    Util.CreateTreeNode([6, 3, 5, null, 2, 0, null, null, 1])
                },
                {
                    [3, 2, 1],
                    Util.CreateTreeNode([3, null, 2, null, 1])
                }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(int[] nums, TreeNode expected)
    {
        var actual = Solution.ConstructMaximumBinaryTree(nums);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }
}