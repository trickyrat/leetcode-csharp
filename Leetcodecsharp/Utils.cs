using Leetcodecsharp.DataStructure;

using System.Collections.Generic;
using System.Text;

namespace Leetcodecsharp
{
    public static class Utils
    {
        public static ListNode InitLinkedList(List<int> data)
        {
            ListNode head = new ListNode(data[0]);
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
                if(head is not null)
                {
                    sb.Append("->");
                }
            }
            return sb.ToString();
        }
    }
}
