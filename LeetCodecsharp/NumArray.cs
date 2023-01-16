// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCodecsharp;
/// <summary>
/// LeetCode 303 Number Array
/// </summary>
public class NumArray
{
    private int[] sum;
    public NumArray(int[] nums)
    {
        int len = nums.Length;
        sum = new int[len + 1];
        for (int i = 0; i < len; i++)
        {
            sum[i + 1] = sum[i] + nums[i];
        }
    }

    public int SumRange(int i, int j) => sum[j + 1] - sum[i];
}
