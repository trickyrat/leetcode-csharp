// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class InsertIntoMaxTreeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.GenerateTreeNode([4, 1, 3, null, null, 2]),
            5,
            Util.GenerateTreeNode([5, 4, null, 1, 3, null, null, 2])
        ];
        yield return
        [
            Util.GenerateTreeNode([5, 2, 4, null, 1]),
            3,
            Util.GenerateTreeNode([5, 2, 4, null, 1, null, 3])
        ];
        yield return
        [
            Util.GenerateTreeNode([5, 2, 3, null, 1]),
            4,
            Util.GenerateTreeNode([5, 2, 4, null, 1, 3])
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int val, TreeNode expected)
    {
        var actual = Solution.InsertIntoMaxTree(root, val);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }

}

