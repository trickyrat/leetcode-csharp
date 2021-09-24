﻿using Leetcodecsharp.DataStructure;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcodecsharp
{
    public static class Utils
    {
        public static ListNode InitLinkedList(List<int> data)
        {
            ListNode head = null;
            if (data.Any())
            {
                head = new ListNode(data[0]);
            }
            ListNode dummy = head;
            int len = data.Count;
            for (int i = 1; i < len; i++)
            {
                dummy.next = new ListNode(data[i]);
                dummy = dummy.next;
            }
            return head;
        }

        public static string PrintListNode(ListNode head)
        {
            StringBuilder sb = new StringBuilder();
            while (head is not null)
            {
                sb.Append($"{head.val}");
                head = head.next;
                if (head is not null)
                {
                    sb.Append("->");
                }
            }
            return sb.ToString();
        }

        public static string PrintMultipleArray(int[][] array)
        {
            StringBuilder sb = new StringBuilder();
            int row = array.Length, col = array[0].Length;
            sb.Append('[');
            for (int r = 0; r < row; r++)
            {
                sb.Append('[');
                for (int c = 0; c < col; c++)
                {
                    sb.Append(col);
                    if (c != col - 1)
                    {
                        sb.Append(", ");
                    }
                }
                sb.Append(']');
                if (r != row - 1)
                {
                    sb.Append('\n');
                }
            }
            sb.Append(']');
            return sb.ToString();
        }
    }
}
