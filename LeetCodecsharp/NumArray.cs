// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCodecsharp;
/// <summary>
/// LeetCode 303 Number Array
/// </summary>
public class NumArray
{
    private int[] _sum;
    public NumArray(int[] nums)
    {
        var len = nums.Length;
        _sum = new int[len + 1];
        for (var i = 0; i < len; i++)
        {
            _sum[i + 1] = _sum[i] + nums[i];
        }
    }

    public int SumRange(int i, int j) => _sum[j + 1] - _sum[i];
}
