// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode;

public class InterviewSolution
{
    /// <summary>
    /// 面试题 01.05. One Away LCCI
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public bool OneEditAway(string first, string second)
    {
        bool OneInsert(string shorter, string longer)
        {
            int len1 = shorter.Length, len2 = longer.Length;
            int index1 = 0, index2 = 0;
            while (index1 < len1 && index2 < len2)
            {
                if (shorter[index1] == longer[index2])
                {
                    index1++;
                }
                index2++;
                if (index2 - index1 > 1)
                {
                    return false;
                }
            }
            return true;
        }

        int m = first.Length, n = second.Length;
        if (n - m == 1)
        {
            return OneInsert(first, second);
        }
        else if (m - n == 1)
        {
            return OneInsert(second, first);
        }
        else if (m == n)
        {
            bool foundDifference = false;
            for (int i = 0; i < m; i++)
            {
                if (first[i] != second[i])
                {
                    if (!foundDifference)
                    {
                        foundDifference = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// 面试题 01.07. Rotate Matrix LCCI
    /// </summary>
    /// <param name="matrix"></param>
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            matrix[i] = matrix[i].Reverse().ToArray();
        }
    }

    /// <summary>
    /// 面试题 08.03. Magic Index LCCI
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMagicIndex(int[] nums)
    {
        int right = nums.Length - 1;
        const int left = 0;
        return FindMagicIndexHelper(nums, left, right);

        int FindMagicIndexHelper(int[] data, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return -1;
            }

            int mid = (rightIndex - leftIndex) / 2 + leftIndex;
            int leftAns = FindMagicIndexHelper(data, leftIndex, mid - 1);
            if (leftAns != -1)
            {
                return leftAns;
            }

            return data[mid] == mid ? mid : FindMagicIndexHelper(data, mid + 1, rightIndex);
        }
    }

    /// <summary>
    /// 面试题 17.11. Find Closest LCCI
    /// </summary>
    /// <param name="words"></param>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns></returns>
    public int FindClosest(string[] words, string word1, string word2)
    {
        int ans = words.Length;
        int index1 = -1, index2 = -1;
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if(word == word1)
            {
                index1 = i;
            }
            else if(word == word2)
            {
                index2 = i;
            }
            if(index1 >= 0 && index2 >= 0)
            {
                ans = Math.Min(ans, Math.Abs(index1 - index2));
            }
        }
        return ans;
    }
}
