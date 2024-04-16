// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class GetAllElementsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.GenerateTreeNode([2, 1, 4]),
            Util.GenerateTreeNode([1, 0, 3]),
            new List<int> { 0, 1, 1, 2, 3, 4 }
        ];
        yield return
        [
            Util.GenerateTreeNode([1, null, 8]),
            Util.GenerateTreeNode([8, 1]),
            new List<int> { 1, 1, 8, 8 }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root1, TreeNode root2, IList<int> expected)
    {
        var actual = Solution.GetAllElements(root1, root2);
        Assert.Equal(expected, expected);
    }
}