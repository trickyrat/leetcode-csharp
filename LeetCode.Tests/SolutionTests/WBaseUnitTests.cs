namespace LeetCode.Tests.SolutionTests;

public class WidthOfBinaryTreeUnitTest
{
    public static TheoryData<TreeNode, int> Data => new()
    {
        {
            Util.GenerateTreeNode([1, 3, 2, 5, 3, null, 9]),
            4
        },
        {
            Util.GenerateTreeNode([1, 3, 2, 5, null, null, 9, 6, null, 7]),
            7
        },
        {
            Util.GenerateTreeNode([1, 3, 2, 5]),
            2
        }
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(TreeNode root, int expected)
    {
        var actual = Solution.WidthOfBinaryTree(root);
        Assert.Equal(expected, actual);
    }
}

