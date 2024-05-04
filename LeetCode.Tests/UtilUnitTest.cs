﻿namespace LeetCode.Tests;

public class UtilUnitTest
{
    public static IEnumerable<object[]> GetTreeNodeData()
    {
        yield return
        [
            new List<int?> { 1, 2, 3 },
            new TreeNode(1, new TreeNode(2), new TreeNode(3))
        ];
        yield return
        [
            new List<int?> { 1, null, 3 },
            new TreeNode(1, null, new TreeNode(3))
        ];
    }

    public static IEnumerable<object[]> GetMatrixData()
    {
        yield return
        [
            new[]
            {
                [1, 2, 3],
                [4, 5, 6],
                new[] { 7, 8, 9 },
            },
            "[[1,2,3]\n [4,5,6]\n [7,8,9]]"
        ];

        yield return
        [
            new[]
            {
                [1, 2],
                [4, 5],
                new[] { 7, 8 },
            },
            "[[1,2]\n [4,5]\n [7,8]]"
        ];

        yield return
        [
            new[]
            {
                [1, 2, 3],
                new[] { 4, 5, 6 }
            },
            "[[1,2,3]\n [4,5,6]]"
        ];

        yield return
        [
            new[]
            {
                [1],
                [2],
                new[] { 3 },
            },
            "[[1]\n [2]\n [3]]"
        ];
        yield return
        [
            new[]
            {
                new[] { 1, 2, 3 },
            },
            "[[1,2,3]]"
        ];
    }

    [Theory]
    [MemberData(nameof(GetTreeNodeData))]
    public void Test_CreateTreeNode_Should_OK(List<int?> nums, TreeNode expected)
    {
        var actual = Util.CreateTreeNode(nums);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }


    [Theory]
    [MemberData(nameof(GetMatrixData))]
    public void Test_ConvertMatrixToString_ShouldBe_OK(int[][] matrix, string expected)
    {
        var actual = Util.ConvertMatrixToString(matrix);
        Assert.Equal(expected, actual);
    }


    [Theory]
    [InlineData(1, 2, 2, 1)]
    [InlineData(-1, -2, -2, -1)]
    [InlineData(0, 1, 1, 0)]
    [InlineData(1, 0, 0, 1)]
    [InlineData(int.MaxValue, int.MinValue, int.MinValue, int.MaxValue)]
    public void Test_SwapByRef_Should_OK(int lhs, int rhs, int expectedLhs, int expectedRhs)
    {
        Util.Swap(ref lhs, ref rhs);
        Assert.Equal(expectedLhs, lhs);
        Assert.Equal(expectedRhs, rhs);
    }


    [Theory]
    [InlineData(new[] { 1, 2 }, 0, 1, new[] { 2, 1 })]
    [InlineData(new[] { 1, 2, 3, 4 }, 0, 3, new[] { 4, 2, 3, 1 })]
    public void Test_SwapByArray_Should_OK(int[] input, int lhs, int rhs, int[] expected)
    {
        Util.Swap(input, lhs, rhs);
        Assert.Equal(expected, input);
    }

    [Theory]
    [InlineData(new[] { 1, 2 }, 1, 2)]
    [InlineData(new[] { 1, 2, 3, 4 }, -1, 3)]
    public void Test_SwapByArray_Should_ThrowIndexOutOfRangeException(int[] input, int lhs, int rhs)
    {
        Assert.Throws<IndexOutOfRangeException>(() => Util.Swap(input, lhs, rhs));
    }
}