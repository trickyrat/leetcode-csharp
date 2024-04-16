// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FindDuplicateSubtreesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.GenerateTreeNode([1, 2, 3, 4, null, 2, 4, null, null, 4]),
            new List<TreeNode>
            {
                Util.GenerateTreeNode([4]),
                Util.GenerateTreeNode([2, 4]),
            }
        ];

        yield return
        [
            Util.GenerateTreeNode([2, 1, 1]),
            new List<TreeNode>
            {
                Util.GenerateTreeNode([1])
            }
        ];

        yield return
        [
            Util.GenerateTreeNode([2, 2, 2, 3, null, 3, null]),
            new List<TreeNode>
            {
                Util.GenerateTreeNode([3]),
                Util.GenerateTreeNode([2, 3]),
            }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, IList<TreeNode> expected)
    {
        var actual = Solution.FindDuplicateSubtrees(root);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }
}