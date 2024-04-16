// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class LongestUnivaluePathUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.GenerateTreeNode([5, 4, 5, 1, 1, null, 5]),
            2
        ];
        yield return
        [
            Util.GenerateTreeNode([1, 4, 5, 4, 4, null, 5]),
            2
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int expected)
    {
        var actual = Solution.LongestUnivaluePath(root);
        Assert.Equal(expected, actual);
    }
}

