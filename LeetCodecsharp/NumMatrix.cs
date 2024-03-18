// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCodecsharp;

public class NumMatrix
{
    private int[,] _sum;
    public NumMatrix(int[][] matrix)
    {
        var m = matrix.Length;
        if (m <= 0) return;
        var n = matrix[0].Length;
        _sum = new int[m + 1, n + 1];
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                _sum[i + 1, j + 1] = _sum[i, j + 1] + _sum[i + 1, j] - _sum[i, j] + matrix[i][j];
            }
        }
    }
    public int SumRange(int row1, int col1, int row2, int col2)
    {
        return _sum[row2 + 1, col2 + 1] - _sum[row1, col2 + 1] - _sum[row2 + 1, col1] + _sum[row1, col1];
    }
}
