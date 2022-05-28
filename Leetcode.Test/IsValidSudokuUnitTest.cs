// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test;

public class IsValidSudokuUnitTest
{
    private readonly Solution _solution;

    public IsValidSudokuUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new char[][]
            {
                new char[]{ '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[]{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[]{ '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[]{ '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[]{ '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[]{ '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[]{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[]{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[]{ '.', '.', '.', '.', '8', '.', '.', '7', '9' },
            },
            true
        };
        yield return new object[]
        {
              new char[][]
              {
                  new char[]{ '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                  new char[]{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                  new char[]{ '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                  new char[]{ '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                  new char[]{ '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                  new char[]{ '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                  new char[]{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                  new char[]{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                  new char[]{ '.', '.', '.', '.', '8', '.', '.', '7', '9' },
              },
              false
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(char[][] board, bool expected)
    {
        bool actual = _solution.IsValidSudoku(board);
        Assert.Equal(expected, actual);
    }
}