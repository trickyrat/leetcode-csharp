// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class IsValidSudokuUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new char[][]
            {
                ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
                ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
                ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
                ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
                ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
                ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
                ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
                ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
                ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
            },
            true
        ];
        yield return
        [
            new char[][]
              {
                  ['8', '3', '.', '.', '7', '.', '.', '.', '.'],
                  ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
                  ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
                  ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
                  ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
                  ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
                  ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
                  ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
                  ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
              },
              false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(char[][] board, bool expected)
    {
        var actual = Solution.IsValidSudoku(board);
        Assert.Equal(expected, actual);
    }
}