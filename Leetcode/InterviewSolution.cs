﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Linq;

namespace Leetcode
{
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
    }
}