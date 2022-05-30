// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Leetcode.DataStructure;

namespace Leetcode;

/// <summary>
/// Leetcode Solution Class
/// </summary>
public class Solution
{
    /// <summary>
    /// 1. Two Sum
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum(int[] nums, int target)
    {
        int[] res = new int[2];
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.TryGetValue(target - nums[i], out int value))
            {
                res[1] = i;
                res[0] = value;
                break;
            }

            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }

        return res;
    }

    /// <summary>
    /// 2. Add Two Numbers
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // 116ms
        ListNode dummyHead = new ListNode(0);
        if (l1 == null && l2 == null)
        {
            return dummyHead;
        }

        int carry = 0;
        ListNode curr = dummyHead;
        while (l1 != null || l2 != null)
        {
            int num1 = l1?.val ?? 0;
            int num2 = l2?.val ?? 0;
            int sum = num1 + num2 + carry;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            carry = sum / 10;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (carry != 0)
        {
            curr.next = new ListNode(carry);
        }

        return dummyHead.next;

        // 148ms
        // ListNode r = new ListNode(-1);
        // ListNode n = r;
        // int carry = 0;
        // while (carry > 0 || l1 != null || l2 != null)
        // {
        //     int v = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
        //     carry = v / 10;
        //     n = n.next = new ListNode(v % 10);
        //     l1 = l1?.next;
        //     l2 = l2?.next;
        // }
        // return r.next;
    }

    /// <summary>
    /// 3. Longest Substring Without Repeating Characters
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLongestSubstring(string s)
    {
        // 96 ms int[]
        // int n = s.Length, ans = 0;
        // int[] index = new int[128];
        // for (int j = 0, i = 0; j < n; j++)
        // {
        //     i = Math.Max(index[s[j]], i);
        //     ans = Math.Max(ans, j - i + 1);
        //     index[s[j]] = j + 1;
        // }
        // return ans;

        // 100 ms HashSet<char>
        // int len = s.Length;
        // HashSet<char> set = new HashSet<char>();
        // int ans = 0, i = 0, j = 0;
        // while (i < len && j < len)
        // {
        //     if (!set.Contains(s[j]))
        //     {
        //         set.Add(s[j++]);
        //         ans = Math.Max(ans, j - i);
        //     }
        //     else set.Remove(s[i++]);
        // }
        // return ans;

        // 100ms Dictionary<char, int>
        int n = s.Length, ans = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int j = 0, i = 0; j < n; j++)
        {
            if (dic.ContainsKey(s[j]))
            {
                i = Math.Max(dic[s[j]], i);
                dic[s[j]] = j + 1;
            }
            else
            {
                dic.Add(s[j], j + 1);
            }

            ans = Math.Max(ans, j - i + 1);
        }

        return ans;
    }

    /// <summary>
    /// 4. Median of Two Sorted Arrays
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length, n = nums2.Length;
        if (m > n)
        {
            (nums1, nums2) = (nums2, nums1);
            (m, n) = (n, m);
        }

        // use binary search
        int min = 0, max = m, halfLen = (m + n + 1) / 2;
        while (min <= max)
        {
            int i = min + (max - min) / 2;
            int j = halfLen - i;
            if (i < max && nums2[j - 1] > nums1[i])
            {
                min++;
            }
            else if (i > min && nums1[i - 1] > nums2[j])
            {
                max--;
            }
            else
            {
                int maxLeft;
                if (i == 0)
                {
                    maxLeft = nums2[j - 1];
                }
                else if (j == 0)
                {
                    maxLeft = nums1[i - 1];
                }
                else
                {
                    maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]);
                }

                if ((m + n) % 2 == 1)
                {
                    return maxLeft;
                }

                int minRight;
                if (i == m)
                {
                    minRight = nums2[j];
                }
                else if (j == n)
                {
                    minRight = nums1[i];
                }
                else
                {
                    minRight = Math.Min(nums2[j], nums1[i]);
                }

                return (maxLeft + minRight) / 2.0;
            }
        }

        return 0.0;
    }

    /// <summary>
    /// 5. Longest Palindromic Substring
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string LongestPalindrome(string s)
    {
        string T = PreProcess(s);
        int n = T.Length;
        int[] P = new int[n];
        int C = 0, R = 0;
        for (int i = 1; i < n - 1; i++)
        {
            int mirror = 2 * C - i;
            P[i] = (R > 1) ? Math.Min(R - i, P[mirror]) : 0;
            while (T[i + 1 + P[i]] == T[i - 1 - P[i]])
            {
                P[i]++;
            }

            if (i + P[i] <= R)
            {
                continue;
            }

            C = i;
            R = i + P[i];
        }

        // Find the maximum element in P
        int maxLen = 0;
        int centerIndex = 0;
        for (int i = 1; i < n - 1; i++)
        {
            if (P[i] <= maxLen)
            {
                continue;
            }

            maxLen = P[i];
            centerIndex = i;
        }

        return s.Substring((centerIndex - 1 - maxLen) / 2, maxLen);

        string PreProcess(string input)
        {
            int len = input.Length;
            if (len == 0)
            {
                return "^$";
            }

            string ret = "^";
            for (int i = 0; i < len; i++)
            {
                ret += string.Concat("#", input.AsSpan(i, 1));
            }

            ret += "#$";
            return ret;
        }
    }

    /// <summary>
    /// <para>6. ZigZag Conversion</para>
    /// </summary>
    /// <param name="s"></param>
    /// <param name="numRows"></param>
    /// <returns></returns>
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1)
        {
            return s;
        }

        StringBuilder res = new StringBuilder();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < s.Length; j += 2 * numRows - 2)
            {
                int index = i + j;
                if (index < s.Length)
                {
                    res.Append(s[index]);
                }

                if (i == 0 || i == numRows - 1)
                {
                    continue;
                }

                index = j + 2 * numRows - 2 - i;
                if (index < s.Length)
                {
                    res.Append(s[index]);
                }
            }
        }

        return res.ToString();
    }

    /// <summary>
    /// 7. Reverse Integer
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int Reverse(int x)
    {
        int rev = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;
            switch (rev)
            {
                case > int.MaxValue / 10:
                case int.MaxValue / 10 when pop > 7:
                case < int.MinValue / 10:
                case int.MinValue / 10 when pop < -8:
                    return 0;
                default:
                    rev = rev * 10 + pop;
                    break;
            }
        }

        return rev;
    }

    /// <summary>
    /// 8. String to Integer(atoi)
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public int Atoi(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int sign = 1;
        int bas = 0;
        int i = 0;
        while (str[i] == ' ')
        {
            i++;
        }

        if (str[i] == '-' || str[i] == '+')
        {
            sign = str[i++] == '-' ? -1 : 1;
        }

        while (i < str.Length && str[i] >= '0' && str[i] <= '9')
        {
            if (bas > int.MaxValue / 10 || (bas == int.MaxValue / 10 && str[i] - '0' > 7))
            {
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }

            bas = 10 * bas + (str[i++] - '0');
        }

        return bas * sign;
    }

    /// <summary>
    /// 9. Palindrome Number
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x != 0 && x % 10 == 0))
        {
            return false;
        }

        int res = 0;
        while (res < x)
        {
            res = res * 10 + x % 10;
            x /= 10;
        }

        return (x == res || x == res / 10);
        // if (x < 10) return true;
        // int n = 0, temp = x;
        // while (temp / 10 != 0)
        // {
        //     n += temp % 10;
        //     n *= 10;
        //     temp /= 10;
        // }
        // n += temp % 10;
        // return (n == x);
    }

    /// <summary>
    /// 10. Regular Expression Matching
    /// </summary>
    /// <param name="text">string input</param>
    /// <param name="pattern">match pattern</param>
    /// <returns></returns>
    public bool IsMatch(string text, string pattern)
    {
        bool[,] dp = new bool[text.Length + 1, pattern.Length + 1];
        dp[text.Length, pattern.Length] = true;
        for (int i = text.Length; i >= 0; i--)
        {
            for (int j = pattern.Length - 1; j >= 0; j--)
            {
                bool firstMatch = (i < text.Length
                                   && (pattern[j] == text[i] || pattern[j] == '.'));
                if (j + 1 < pattern.Length && pattern[j + 1] == '*')
                {
                    dp[i, j] = dp[i, j + 2] || firstMatch && dp[i + 1, j];
                }
                else
                {
                    dp[i, j] = firstMatch && dp[i + 1, j + 1];
                }
            }
        }

        return dp[0, 0];
    }

    /// <summary>
    /// 11. Container With Most Water
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0, right = height.Length - 1;
        while (left < right)
        {
            maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    /// <summary>
    /// 12. Integer to Roman
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public string IntToRoman(int num)
    {
        string[] M = { "", "M", "MM", "MMM" };
        string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
    }

    /// <summary>
    /// 13. Roman to Integer
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int value = 0;
        char prev = s[0];
        foreach (char curr in s)
        {
            value += dic[curr];
            if (dic[prev] < dic[curr])
            {
                value -= dic[prev] * 2;
            }

            prev = curr;
        }

        return value;
    }

    /// <summary>
    /// 14. Longest Common Prefix
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }

        string pre = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(pre, StringComparison.Ordinal) != 0)
            {
                pre = pre[..^1];
            }
        }

        return pre;
    }

    /// <summary>
    /// 15. Three Sum
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> res = new List<IList<int>>();
        //for (int i = 0; i < nums.Length - 2; i++)
        //{
        //    if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
        //    {
        //        int lo = i + 1, hi = nums.Length - 1, sum = 0 - nums[i];
        //        // two sum
        //        while (lo < hi)
        //        {
        //            if (nums[lo] + nums[hi] == sum)
        //            {
        //                res.Add(
        //                    new List<int>
        //                    {
        //                        nums[i],
        //                        nums[lo],
        //                        nums[hi]
        //                    });

        //                while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
        //                while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
        //                lo++;
        //                hi--;
        //            }
        //            else if (nums[lo] + nums[hi] < sum)
        //            {
        //                while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
        //                lo++;
        //            }
        //            else
        //            {
        //                while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
        //                hi--;
        //            }
        //        }
        //    }
        //}

        int len = nums.Length;
        for (int i = 0; i < len; i++)
        {
            int target = -nums[i];
            int left = i + 1;
            int right = len - 1;
            if (target < 0)
            {
                break;
            }

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    List<int> tmp = new List<int> { nums[i], nums[left], nums[right] };
                    res.Add(tmp);
                    while (left < right && nums[left] < tmp[1])
                    {
                        left++;
                    }

                    while (left < right && nums[right] == tmp[2])
                    {
                        right--;
                    }
                }
            }

            while (i + 1 < len && nums[i + 1] == nums[i])
            {
                i++;
            }
        }

        return res;
    }

    /// <summary>
    /// 16. Three Sum Closest
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length < 3)
        {
            return 0;
        }

        int closest = nums[0] + nums[1] + nums[2];
        int len = nums.Length;
        Array.Sort(nums);
        for (int first = 0; first < len - 2; first++)
        {
            if (first > 0 && nums[first] == nums[first - 1])
            {
                continue;
            }

            int second = first + 1;
            int third = len - 1;
            while (second < third)
            {
                int currentSum = nums[first] + nums[second] + nums[third];
                if (currentSum == target)
                {
                    return currentSum;
                }

                if (Math.Abs(target - currentSum) < Math.Abs(target - closest))
                {
                    closest = currentSum;
                }

                if (currentSum > target)
                {
                    third--;
                }
                else
                {
                    second++;
                }
            }
        }

        return closest;
    }

    /// <summary>
    /// 17. Letter Combinations of a Phone Number
    /// </summary>
    /// <param name="digits">input digits</param>
    /// <returns></returns>
    public IList<string> LetterCombinations(string digits)
    {
        string[] map = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        if (string.IsNullOrEmpty(digits))
        {
            return new List<string>();
        }

        Queue<string> ans = new Queue<string>();
        ans.Enqueue("");
        for (int i = 0; i < digits.Length; i++)
        {
            int x = digits[i] - '0';
            while (ans.Peek().Length == i)
            {
                string t = ans.Dequeue();
                foreach (char c in map[x])
                {
                    ans.Enqueue(t + c);
                }
            }
        }

        return ans.ToList();
    }

    /// <summary>
    /// 18. 4Sum
    /// </summary>
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> res = new List<IList<int>>();
        int n = nums.Length;
        if (n < 4)
        {
            return res;
        }

        Array.Sort(nums);
        for (int i = 0; i < n - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target)
            {
                break;
            }

            if (nums[i] + nums[n - 3] + nums[n - 2] + nums[n - 1] < target)
            {
                continue;
            }

            for (int j = i + 1; j < n - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue;
                }

                if (nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target)
                {
                    break;
                }

                if (nums[i] + nums[j] + nums[n - 2] + nums[n - 1] < target)
                {
                    continue;
                }

                int left = j + 1, right = n - 1;
                while (left < right)
                {
                    int sum = nums[left] + nums[right] + nums[i] + nums[j];
                    if (sum < target)
                    {
                        left++;
                    }
                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        do
                        {
                            left++;
                        } while (nums[left] == nums[left - 1] && left < right);

                        do
                        {
                            right--;
                        } while (nums[right] == nums[right + 1] && left < right);
                    }
                }
            }
        }

        return res;
    }

    /// <summary>
    /// 19. Remove Nth Node From End of List
    /// </summary>
    /// <param name="head"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode first = dummy;
        ListNode second = dummy;
        for (int i = 0; i <= n; i++)
        {
            first = first.next;
        }

        while (first is not null)
        {
            first = first.next;
            second = second.next;
        }

        second.next = second.next.next;
        return dummy.next;
    }

    /// <summary>
    /// 20. Valid Parentheses
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char item in s)
        {
            switch (item)
            {
                case '(':
                    stack.Push(')');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                default:
                    {
                        if (stack.Count == 0 || stack.Pop() != item)
                        {
                            return false;
                        }

                        break;
                    }
            }
        }

        return stack.Count == 0;
    }

    /// <summary>
    /// 21. Merge Two Sorted Lists
    /// </summary>
    /// <param name="l1">first list</param>
    /// <param name="l2">second list</param>
    /// <returns>merged list</returns>
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode head = dummyHead;
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                head.next = l1;
                l1 = l1.next;
            }
            else
            {
                head.next = l2;
                l2 = l2.next;
            }

            head = head.next;
        }

        head.next = l1 ?? l2;
        return dummyHead.next;

        //if (l1 == null) { return l2; }
        //if (l2 == null) { return l1; }
        //ListNode ans = null;
        //if (l1.val < l2.val)
        //{
        //    ans = l1;
        //    ans.next = MergeTwoLists(l1.next, l2);
        //}
        //else
        //{
        //    ans = l2;
        //    ans.next = MergeTwoLists(l1, l2.next);
        //}
        //return ans;
    }

    /// <summary>
    /// 22. Generate Parentheses
    /// </summary>
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> ans = new List<string>();
        // if (n == 0)
        //     ans.Add("");
        // else
        // {
        //     for (int c = 0; c < n; c++)
        //         foreach (string left in GenerateParenthesis(c))
        //             foreach (string right in GenerateParenthesis(n - 1 - c))
        //                 ans.Add("(" + left + ")" + right);
        // }
        // return ans;
        Backtrack(ans, "", 0, 0, n);
        return ans;

        void Backtrack(IList<string> list, string str, int open, int close, int n)
        {
            if (str.Length == n * 2)
            {
                list.Add(str);
                return;
            }

            if (open < n)
            {
                Backtrack(list, str + "(", open + 1, close, n);
            }

            if (close < open)
            {
                Backtrack(list, str + ")", open, close + 1, n);
            }
        }
    }

    /// <summary>
    /// 23. Merge K Sorted Lists
    /// </summary>
    /// <param name="lists">the array of lists</param>
    /// <returns>merged list</returns>
    public ListNode MergeKLists(ListNode[] lists)
    {
        int len = lists.Length;
        int interval = 1;
        while (interval < len)
        {
            for (int i = 0; i < len - interval; i += interval * 2)
            {
                lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
            }

            interval *= 2;
        }

        return len > 0 ? lists[0] : null;
    }

    /// <summary>
    /// 24. Swap Node in Pairs
    /// </summary>
    public ListNode SwapPairs(ListNode head)
    {
        ListNode dummy = new ListNode(0) {
            next = head
        };
        ListNode curr = dummy;
        while (curr.next?.next != null)
        {
            ListNode a = curr.next;
            ListNode b = curr.next.next;
            a.next = b.next;
            curr.next = b;
            curr.next.next = a;
            curr = curr.next.next;
        }

        return dummy.next;
    }

    /// <summary>
    /// 25. Reverse Nodes in k-Group
    /// </summary>
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        // Non-recursive
        int n = 0;
        for (ListNode i = head; i != null;)
        {
            n++;
            i = i.next;
        }

        ListNode dummy = new ListNode(0) {
            next = head
        };
        for (ListNode prev = dummy, tail = head; n >= k; n -= k)
        {
            for (int i = 1; i < k; i++)
            {
                ListNode next = tail.next.next;
                tail.next.next = prev.next;
                prev.next = tail.next;
                tail.next = next;
            }

            prev = tail;
            tail = tail.next;
        }

        return dummy.next;

        // Recursive
        // ListNode curr = head;
        // int count = 0;
        // while(curr!=null && count != k)
        // {
        //     curr = curr.next;
        //     count++;
        // }
        // if(count == k)
        // {
        //     curr = ReverseKGroup(curr, k);
        //     while(count-- > 0)
        //     {
        //         ListNode tmp = head.next;
        //         head.next = curr;
        //         curr = head;
        //         head = tmp;
        //     }
        //     head = curr;
        // }
        // return head;
    }

    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicates(int[] nums)
    {
        int i = nums.Length > 0 ? 1 : 0;
        foreach (int n in nums)
        {
            if (n > nums[i - 1])
            {
                nums[i++] = n;
            }
        }

        return i;
    }

    /// <summary>
    /// 27. Remove Element
    /// </summary>
    public int RemoveElement(int[] nums, int val)
    {
        int len = nums.Length;
        int found = 0;
        for (int i = 0; i < len; i++)
        {
            if (found > 0)
            {
                nums[i - found] = nums[i];
            }

            if (nums[i] == val)
            {
                found++;
            }
        }

        return len - found;
    }

    /// <summary>
    /// 28. Implement strStr()
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public int StrStr(string haystack, string needle)
    {
        int m = haystack.Length, n = needle.Length;
        if (n < 1)
        {
            return 0;
        }

        List<int> lps = KMPProcess(needle);
        for (int i = 0, j = 0; i < m;)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
            }

            if (j == n)
            {
                return i - j;
            }

            if (i >= m || haystack[i] == needle[j])
            {
                continue;
            }

            if (j > 0)
            {
                j = lps[j - 1];
            }
            else
            {
                i++;
            }
        }

        return -1;

        List<int> KMPProcess(string s)
        {
            int n = needle.Length;
            List<int> lps = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lps.Add(0);
            }

            for (int i = 1, len = 0; i < n;)
            {
                if (s[i] == s[len])
                {
                    lps[i] = ++len;
                    i++;
                }
                else if (len > 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i++] = 0;
                }
            }

            return lps;
        }
    }

    /// <summary>
    /// 29. Divide Two Integers
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divisor"></param>
    /// <returns></returns>
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0 || (dividend == int.MinValue && divisor == -1))
        {
            return int.MaxValue;
        }

        int sign = dividend < 0 ^ divisor < 0 ? -1 : 1;
        long dvd = Math.Abs((long)dividend);
        long dvs = Math.Abs((long)divisor);
        int res = 0;
        while (dvd >= dvs)
        {
            long tmp = dvs;
            int multiple = 1;
            while (dvd >= (tmp << 1))
            {
                tmp <<= 1;
                multiple <<= 1;
            }

            dvd -= tmp;
            res += multiple;
        }

        return sign * res;
    }

    /// <summary>
    /// 30. Substring with Concatenation of All Words
    /// </summary>
    public IList<int> FindSubstring(string s, string[] words)
    {
        IList<int> ret = new List<int>();
        if (s.Length == 0 || words.Length == 0)
        {
            return ret;
        }

        int n = s.Length, size = words.Length, len = words[0].Length;
        Dictionary<string, int> map = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (map.ContainsKey(word))
            {
                map[word]++;
            }
            else
            {
                map.Add(word, 1);
            }
        }

        for (int i = 0; i < len; i++)
        {
            int left = i, count = 0;
            Dictionary<string, int> window = new Dictionary<string, int>();
            for (int j = i; j + len - 1 < n; j += len)
            {
                string tmp = s.Substring(j, len);
                if (!map.ContainsKey(tmp))
                {
                    window.Clear();
                    count = 0;
                    left = j + len;
                }
                else
                {
                    if (window.ContainsKey(tmp))
                    {
                        window[tmp]++;
                    }
                    else
                    {
                        window.Add(tmp, 1);
                    }

                    count++;
                    while (left + len - 1 < n && window[tmp] > map[tmp])
                    {
                        window[s.Substring(left, len)]--;
                        count--;
                        left += len;
                    }

                    if (count != size)
                    {
                        continue;
                    }

                    ret.Add(left);
                    window[s.Substring(left, len)]--;
                    count--;
                    left += len;
                }
            }
        }

        return ret;
    }

    /// <summary>
    /// 31. Next Permutation
    /// </summary>
    public void NextPermutation(int[] nums)
    {
        int i = nums.Length - 2;
        while (i >= 0 && nums[i + 1] <= nums[i])
        {
            i--;
        }

        if (i >= 0)
        {
            int j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }

            Utilities.Swap(ref nums[i], ref nums[j]);
        }

        Reverse(nums, i + 1);

        void Reverse(int[] data, int start)
        {
            int i = start, j = data.Length - 1;
            while (i < j)
            {
                Utilities.Swap(ref data[i], ref data[j]);
                i++;
                j--;
            }
        }
    }

    /// <summary>
    /// 32. Longest Valid Parentheses
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LongestValidParentheses(string s)
    {
        //int maxans = 0;
        //int len = s.Length;
        //int[] dp = new int[len];
        //for (int i = 1; i < len; i++)
        //{
        //    if (s[i] == ')')
        //    {
        //        if (s[i - 1] == '(')
        //        {
        //            dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
        //        }
        //        else if (i - dp[i - 1] > 0 && s[i - dp[i - 1] - 1] == '(')
        //        {
        //            dp[i] = dp[i - 1] + ((i - dp[i - 1]) >= 2 ? dp[i - dp[i - 1] - 2] : 0) + 2;
        //        }
        //        maxans = Math.Max(maxans, dp[i]);
        //    }
        //}
        //return maxans;
        int len = s.Length;
        int left = 0, right = 0, maxLen = 0;
        for (int i = 0; i < len; i++)
        {
            if (s[i] == '(')
            {
                left++;
            }
            else
            {
                right++;
            }

            if (left == right)
            {
                maxLen = Math.Max(maxLen, 2 * right);
            }
            else if (right > left)
            {
                left = right = 0;
            }
        }

        left = right = 0;
        for (int i = len - 1; i >= 0; i--)
        {
            if (s[i] == '(')
            {
                left++;
            }
            else
            {
                right++;
            }

            if (left == right)
            {
                maxLen = Math.Max(maxLen, 2 * left);
            }
            else if (left > right)
            {
                left = right = 0;
            }
        }

        return maxLen;
    }

    /// <summary>
    /// 33. Search in Rotated Sorted Array
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int Search(int[] nums, int target)
    {
        int n = nums.Length;
        switch (n)
        {
            case 0:
                return -1;
            case 1:
                return nums[0] == target ? 0 : -1;
        }

        int l = 0, r = n - 1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[0] <= nums[mid])
            {
                if (nums[0] <= target && target < nums[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            else
            {
                if (nums[mid] < target && target <= nums[n - 1])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
        }

        return -1;
    }

    /// <summary>
    /// 34. Find First and Last Position of Element in Sorted Array
    /// </summary>
    public int[] SearchRange(int[] nums, int target)
    {
        int[] missingResult = new int[] { -1, -1 };
        //int[] res = new int[] { 0, 0 };
        //if (nums.Length < 1)
        //{
        //    return missingResult;
        //}
        //int lo = 0, hi = nums.Length - 1;
        //while (lo < hi)
        //{
        //    int mid = lo + (hi - lo) / 2;
        //    if (nums[mid] >= target)
        //    {
        //        hi = mid;
        //    }
        //    else
        //    {
        //        lo = mid + 1;
        //    }
        //}
        //int first = nums[lo] == target ? lo : -1;
        //if (first == -1)
        //{
        //    return missingResult;
        //}
        //lo = first;
        //hi = nums.Length - 1;
        //while (lo < hi)
        //{
        //    int mid = lo + (hi - lo + 1) / 2;
        //    if (nums[mid] <= target)
        //    {
        //        lo = mid;
        //    }
        //    else
        //    {
        //        hi = mid - 1;
        //    }
        //}
        //res[0] = first;
        //res[1] = lo;
        //return res;
        int leftIndex = BinarySearch(nums, target, true);
        int rightIndex = BinarySearch(nums, target, false) - 1;
        if (leftIndex <= rightIndex && rightIndex < nums.Length && nums[leftIndex] == nums[rightIndex])
        {
            return new[] { leftIndex, rightIndex };
        }

        return missingResult;

        int BinarySearch(int[] nums, int target, bool lower)
        {
            int l = 0, r = nums.Length - 1, ans = nums.Length;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] > target || (lower && nums[mid] >= target))
                {
                    r = mid - 1;
                    ans = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return ans;
        }
    }

    /// <summary>
    /// 35. Search Insert Position
    /// </summary>
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left] < target ? left + 1 : left;
    }

    /// <summary>
    /// 36. Valid Sudoku
    /// </summary>
    public bool IsValidSudoku(char[][] board)
    {
        // Dictionary<int, int>[] rows = new Dictionary<int, int>[9]; 
        // Dictionary<int, int>[] columns = new Dictionary<int, int>[9]; 
        // Dictionary<int, int>[] boxes = new Dictionary<int, int>[9]; 

        // for (int i = 0; i < 9; i++)
        // {
        //     rows[i] = new Dictionary<int, int>();
        //     columns[i] = new Dictionary<int, int>();
        //     boxes[i] = new Dictionary<int, int>();
        // }
        // for (int i = 0; i < 9; i++)
        // {
        //     for(int j = 0; j < 9; j++)
        //     {
        //         char num = board[i][j];
        //         if(num != '.')
        //         {
        //             int n = (int)num;
        //             int box_index = (i / 3) * 3 + j / 3;
        //             rows[i][n] = rows[i].GetValueOrDefault(n, 0) + 1;
        //             columns[j][n] = columns[j].GetValueOrDefault(n, 0) + 1;
        //             boxes[box_index][n] = boxes[box_index].GetValueOrDefault(n, 0) + 1;
        //             if (rows[i][n] > 1 || columns[j][n] > 1 || boxes[box_index][n] > 1)
        //                 return false;
        //         }
        //     }
        // }
        // return true;

        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char num = board[i][j];
                if (num == '.')
                {
                    continue;
                }

                if (!seen.Add(num + " in row " + i) ||
                    !seen.Add(num + " in column " + j) ||
                    !seen.Add(num + " in block " + i / 3 + "-" + j / 3))
                {
                    return false;
                }
            }
        }

        return true;
    }

    /// <summary>
    /// 37. Sudoku Solver 
    /// </summary>
    public void SolveSudoku(char[][] board)
    {
        bool DoSolve(char[][] dataBoard, int row, int col)
        {
            for (int i = row; i < 9; i++, col = 0)
            {
                for (int j = col; j < 9; j++)
                {
                    if (dataBoard[i][j] != '.')
                    {
                        continue;
                    }

                    for (char num = '1'; num <= '9'; num++)
                    {
                        if (!IsValid(dataBoard, i, j, num))
                        {
                            continue;
                        }

                        dataBoard[i][j] = num;
                        if (DoSolve(dataBoard, i, j + 1))
                        {
                            return true;
                        }

                        dataBoard[i][j] = '.';
                    }

                    return false;
                }
            }

            return true;
        }

        bool IsValid(char[][] dataBoard, int row, int col, char num)
        {
            int blkRow = (row / 3) * 3, blkCol = (col / 3) * 3;
            for (int i = 0; i < 9; i++)
            {
                if (dataBoard[i][col] == num || dataBoard[row][i] == num ||
                    dataBoard[blkRow + i / 3][blkCol + i % 3] == num)
                {
                    return false;
                }
            }

            return true;
        }

        DoSolve(board, 0, 0);
    }

    /// <summary>
    /// 38. Count and Say
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string CountAndSay(int n)
    {
        if (n < 0)
        {
            return "-1";
        }

        string result = "1";
        for (int i = 1; i < n; ++i)
        {
            result = Build(result);
        }

        return result;

        string Build(string s)
        {
            StringBuilder sb = new StringBuilder();
            int p = 0;
            while (p < s.Length)
            {
                char val = s[p];
                int count = 0;
                while (p < s.Length && s[p] == val)
                {
                    p++;
                    count++;
                }

                sb.Append(count);
                sb.Append(val);
            }

            return sb.ToString();
        }
    }

    /// <summary>
    /// 39. Combination Sum
    /// </summary>
    /// <param name="candidates"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        List<int> combine = new List<int>();
        Dfs(candidates, target, ans, combine, 0);
        return ans;

        void Dfs(int[] data, int target, IList<IList<int>> ans, List<int> combine, int idx)
        {
            if (idx == data.Length)
            {
                return;
            }

            if (target == 0)
            {
                ans.Add(new List<int>(combine));
                return;
            }

            Dfs(data, target, ans, combine, idx + 1);
            if (target - data[idx] < 0)
            {
                return;
            }

            combine.Add(data[idx]);
            Dfs(data, target - data[idx], ans, combine, idx);
            combine.RemoveAt(combine.Count - 1);
        }
    }

    /// <summary>
    /// 41. First Missing Positive
    /// </summary>
    public int FirstMissingPositive(int[] nums)
    {
        int len = nums.Length;
        for (int i = 0; i < len; i++)
        {
            while (nums[i] > 0 && nums[i] <= len && nums[nums[i] - 1] != nums[i])
            {
                Utilities.Swap(ref nums[i], ref nums[nums[i] - 1]);
            }
        }

        for (int i = 0; i < len; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }

        return len + 1;
    }

    /// <summary>
    /// 42. Trap Rain Water
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    public int Trap(int[] height)
    {
        if (height == null)
        {
            return 0;
        }

        int l = 0, r = height.Length - 1;
        int lMax = 0, rMax = 0;
        int ans = 0;
        while (l < r)
        {
            if (l >= r)
            {
                continue;
            }

            if (height[l] < height[r])
            {
                if (height[l] >= lMax)
                {
                    lMax = height[l];
                }
                else
                {
                    ans += (lMax - height[l]);
                }

                l++;
            }
            else
            {
                if (height[r] >= rMax)
                {
                    rMax = height[r];
                }
                else
                {
                    ans += (rMax - height[r]);
                }

                r--;
            }
        }

        return ans;
    }

    /// <summary>
    /// 43. Multiply String
    /// </summary>
    public string Multiply(string num1, string num2)
    {
        int m = num1.Length, n = num2.Length;
        int[] pos = new int[m + n];
        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int p1 = i + j, p2 = i + j + 1;
                int sum = mul + pos[p2];
                pos[p1] += sum / 10;
                pos[p2] = (sum) % 10;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (int item in pos)
        {
            if (!(sb.Length == 0 && item == 0))
            {
                sb.Append(item);
            }
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }

    /// <summary>
    /// 45. Jump Game II
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int Jump(int[] nums)
    {
        int n = nums.Length;
        if (n < 2)
        {
            return 0;
        }

        int level = 0;
        int currentMax = 0;
        int i = 0;
        int nextMax = 0;
        while (currentMax - i + 1 > 0)
        {
            level++;
            for (; i <= currentMax; i++)
            {
                nextMax = Math.Max(nextMax, nums[i] + i);
                if (nextMax >= n - 1)
                {
                    return level;
                }
            }

            currentMax = nextMax;
        }

        return 0;

        // with greedy 
        //int jumps = 0, currEnd = 0, currFarthest = 0;
        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    currFarthest = Math.Max(currFarthest, i + nums[i]); ;
        //    if (i == currEnd)
        //    {
        //        jumps++;
        //        currEnd = currFarthest;
        //        if (currEnd >= nums.Length - 1)
        //            break;
        //    }
        //}
        //return jumps;
    }

    /// <summary>
    /// 46. Permutations
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Queue<IList<int>> q = new Queue<IList<int>>();
        q.Enqueue(new List<int>());
        foreach (int t in nums)
        {
            int size = q.Count;
            while (size-- > 0)
            {
                IList<int> list = q.Dequeue();
                for (int j = 0; j <= list.Count; j++)
                {
                    List<int> tmp = new List<int>(list);
                    tmp.Insert(j, t);
                    q.Enqueue(tmp);
                }
            }
        }

        while (q.Count > 0)
        {
            res.Add(q.Dequeue());
        }

        return res.Reverse().ToList();
    }

    /// <summary>
    /// 48. Rotate Image
    /// </summary>
    /// <param name="nums"></param>
    public void Rotate(int[][] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                (nums[i][j], nums[n - i - 1][j]) = (nums[n - i - 1][j], nums[i][j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (nums[i][j], nums[j][i]) = (nums[j][i], nums[i][j]);
            }
        }
    }

    /// <summary>
    /// 50. Power
    /// </summary>
    /// <param name="x">base</param>
    /// <param name="n">power</param>
    /// <returns></returns>
    public double MyPow(double x, int n)
    {
        // if (n == 0) return 1;
        // if (n == Int32.MinValue)
        // {
        //     x = x * x;
        //     n = n / 2;
        // }
        // if (n < 0)
        // {
        //     n = -n;
        //     x = 1 / x;
        // }
        // return (n % 2 == 0) ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);

        double res = 1.0;
        for (int i = n; i != 0; i /= 2)
        {
            if (i % 2 != 0)
            {
                res *= x;
            }

            x *= x;
        }

        return n < 0 ? 1 / res : res;
    }

    /// <summary>
    /// 53. Maximum Subarray
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxSubArray(int[] nums)
    {
        int pre = 0, maxAns = nums[0];
        foreach (int num in nums)
        {
            pre = Math.Max(pre + num, num);
            maxAns = Math.Max(maxAns, pre);
        }
        return maxAns;
    }

    /// <summary>
    /// 54. Spiral Matrix
    /// </summary>
    public IList<int> SpiralOrder(int[][] matrix)
    {
        if (matrix.Length == 0)
        {
            return new List<int>() { 0 };
        }

        int startRow = 0, startColumn = 0;
        int height = matrix.Length, width = matrix[0].Length;
        IList<int> result = new List<int>();
        while (true)
        {
            if (height == 0 || width == 0) // can also use if(index == height * width) 
            {
                break;
            }

            for (int col = startColumn; col < startColumn + width; col++)
            {
                result.Add(matrix[startRow][col]);
            }

            startRow++;
            height--;
            if (height == 0)
            {
                break;
            }

            for (int row = startRow; row < startRow + height; row++)
            {
                result.Add(matrix[row][startColumn + width - 1]);
            }

            width--;
            if (width == 0)
            {
                break;
            }

            for (int col = startColumn + width - 1; col >= startColumn; col--)
            {
                result.Add(matrix[startRow + height - 1][col]);
            }

            height--;
            if (height == 0)
            {
                break;
            }

            for (int row = startRow + height - 1; row >= startRow; row--)
            {
                result.Add(matrix[row][startColumn]);
            }

            startColumn++;
            width--;
        }

        return result;
    }

    /// <summary>
    /// 55. Jump Game
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanJump(int[] nums)
    {
        int lastPos = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= lastPos)
            {
                lastPos = i;
            }
        }

        return lastPos == 0;
    }

    /// <summary>
    /// 56.合并区间
    /// </summary>
    /// <param name="intervals"></param>
    /// <returns></returns>
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return Array.Empty<int[]>();
        }

        Array.Sort(intervals, (l, r) => l[0] - r[0]);
        List<int[]> merged = new List<int[]>();
        foreach (int[] t in intervals)
        {
            int n = merged.Count;
            int l = t[0], r = t[1];
            if (n == 0 || merged[n - 1][1] < l)
            {
                merged.Add(new[] { l, r });
            }
            else
            {
                merged[n - 1][1] = Math.Max(merged[n - 1][1], r);
            }
        }

        return merged.ToArray();
    }

    /// <summary>
    /// 58. Length Of Last Word
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLastWord(string s)
    {
        // s = s.Trim();
        // int lastIndex = s.LastIndexOf(' ') + 1;
        // return s.Length - lastIndex;
        int len = 0, tail = s.Length - 1;
        while (tail >= 0 && s[tail] == ' ')
        {
            tail--;
        }

        while (tail >= 0 && s[tail] != ' ')
        {
            len++;
            tail--;
        }

        return len;
    }

    /// <summary>
    /// 59. Spiral Matrix II
    /// </summary>
    public int[][] GenerateMatrix(int n)
    {
        if (n == 0)
        {
            return new[] { new[] { 0 } };
        }

        int startRow = 0, startColumn = 0;
        int index = 1, height = n, width = n;
        int[][] matrix = new int[n][];
        for (int r = 0; r < n; r++)
        {
            matrix[r] = new int[n];
        }

        while (true)
        {
            if (width == 0)
            {
                break;
            }

            for (int col = startColumn; col < startColumn + width; col++)
            {
                matrix[startRow][col] = index++;
            }

            startRow++;
            height--;
            if (height == 0)
            {
                break;
            }

            for (int row = startRow; row < startRow + height; row++)
            {
                matrix[row][startColumn + width - 1] = index++;
            }

            width--;
            if (width == 0)
            {
                break;
            }

            for (int col = startColumn + width - 1; col >= startColumn; col--)
            {
                matrix[startRow + height - 1][col] = index++;
            }

            height--;
            if (height == 0)
            {
                break;
            }

            for (int row = startRow + height - 1; row >= startRow; row--)
            {
                matrix[row][startColumn] = index++;
            }

            startColumn++;
            width--;
        }

        return matrix;
    }

    /// <summary>
    /// 61. Rotate List
    /// </summary>
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null)
        {
            return null;
        }

        if (head.next == null)
        {
            return head;
        }

        ListNode oldTail = head;
        int n;
        for (n = 1; oldTail.next != null; n++)
        {
            oldTail = oldTail.next;
        }

        oldTail.next = head;
        ListNode newTail = head;
        for (int i = 0; i < n - k % n - 1; i++)
        {
            newTail = newTail.next;
        }

        ListNode newHead = newTail.next;
        newTail.next = null;
        return newHead;
    }

    /// <summary>
    /// 62. Unique Paths
    /// </summary>
    public int UniquePaths(int m, int n)
    {
        int[] dp = new int[n];
        Array.Fill(dp, 1);
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[j] += dp[j - 1];
            }
        }

        return dp[n - 1];
    }

    /// <summary>
    /// 63. Unique Paths II
    /// </summary>
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        // if(obstacleGrid[0][0] == 1)
        //     return 0;
        // int height = obstacleGrid.Length;
        // int width = obstacleGrid[0].Length;
        // obstacleGrid[0][0] = 1;
        // for(int row = 1; row < height; row++)
        //     obstacleGrid[row][0] = (obstacleGrid[row][0] == 0 && obstacleGrid[row - 1][0] == 1) ? 1 : 0;
        // for(int col = 1; col < width; col++)
        //     obstacleGrid[0][col] = (obstacleGrid[0][col] == 0 && obstacleGrid[0][col - 1] == 1) ? 1 : 0;
        // for(int row = 1; row < height; row++)
        //     for(int col = 1; col < width; col++)
        //         if(obstacleGrid[row][col] == 0)
        //             obstacleGrid[row][col] = obstacleGrid[row - 1][col] + obstacleGrid[row][col - 1];
        //         else
        //             obstacleGrid[row][col] = 0;
        // return obstacleGrid[height - 1][width - 1];

        int width = obstacleGrid[0].Length;
        int[] dp = new int[width];
        dp[0] = 1;
        foreach (int[] row in obstacleGrid)
        {
            for (int j = 0; j < width; j++)
            {
                if (row[j] == 1)
                {
                    dp[j] = 0;
                }
                else if (j > 0)
                {
                    dp[j] += dp[j - 1];
                }
            }
        }

        return dp[width - 1];
    }

    /// <summary>
    /// 64. Minimum Path Sum
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MinPathSum(int[][] grid)
    {
        int width = grid[0].Length;
        int height = grid.Length;
        int[][] dp = new int[height][];
        for (int i = 0; i < height; i++)
        {
            dp[i] = new int[width];
        }

        dp[0][0] = grid[0][0];
        for (int i = 1; i < width; i++)
        {
            dp[0][i] = dp[0][i - 1] + grid[0][i];
        }

        for (int i = 1; i < height; i++)
        {
            dp[i][0] = dp[i - 1][0] + grid[i][0];
        }

        for (int i = 1; i < height; i++)
        {
            for (int j = 1; j < width; j++)
            {
                dp[i][j] = Math.Min(dp[i - 1][j], dp[i][j - 1]) + grid[i][j];
            }
        }

        return dp[height - 1][width - 1];
    }

    /// <summary>
    /// 66. Plus One 
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        int[] newNumber = new int[n + 1];
        newNumber[0] = 1;
        return newNumber;
    }

    /// <summary>
    /// 67. Add Binary
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public string AddBinary(string a, string b)
    {
        string s = "";
        int c = 0, i = a.Length - 1, j = b.Length - 1;
        while (i >= 0 || j >= 0 || c == 1)
        {
            c += i >= 0 ? a[i--] - '0' : 0;
            c += j >= 0 ? b[j--] - '0' : 0;
            s = System.Convert.ToChar(c % 2 + '0') + s;
            c /= 2;
        }

        return s;
    }

    /// <summary>
    /// 68. Text Justification
    /// </summary>
    /// <param name="words"></param>
    /// <param name="maxWidth"></param>
    /// <returns></returns>
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        IList<string> ans = new List<string>();
        int right = 0, n = words.Length;
        while (true)
        {
            int left = right;
            int sumLen = 0;
            while (right < n && sumLen + words[right].Length + right - left <= maxWidth)
            {
                sumLen += words[right++].Length;
            }

            if (right == n)
            {
                StringBuilder sb = Join(words, left, n, " ");
                sb.Append(Blank(maxWidth - sb.Length));
                ans.Add(sb.ToString());
                return ans;
            }

            int numWords = right - left;
            int numSpaces = maxWidth - sumLen;
            if (numWords == 1)
            {
                StringBuilder sb = new StringBuilder(words[left]);
                sb.Append(Blank(numSpaces));
                ans.Add(sb.ToString());
                continue;
            }

            int avgSpaces = numSpaces / (numWords - 1);
            int extraSpaces = numSpaces % (numWords - 1);
            StringBuilder curr = new StringBuilder();
            curr.Append(Join(words, left, left + extraSpaces + 1, Blank(avgSpaces + 1)));
            curr.Append(Blank(avgSpaces));
            curr.Append(Join(words, left + extraSpaces + 1, right, Blank(avgSpaces)));
            ans.Add(curr.ToString());
        }

        string Blank(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(' ');
            }

            return sb.ToString();
        }

        StringBuilder Join(string[] words, int left, int right, string seperator)
        {
            StringBuilder sb = new StringBuilder(words[left]);
            for (int i = left + 1; i < right; i++)
            {
                sb.Append(seperator);
                sb.Append(words[i]);
            }

            return sb;
        }
    }

    /// <summary>
    /// 69. Sqrt(x)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int Sqrt(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        int left = 1, right = x;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (mid == x / mid)
            {
                return mid;
            }
            else if (mid < x / mid)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return right;
    }

    /// <summary>
    /// 70. Climb Stairs
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int ClimbStairs(int n)
    {
        // 44ms
        //if (n == 1) return 1;
        //int[] dp = new int[n + 1];
        //dp[1] = 1;
        //dp[2] = 2;
        //for (int i = 3; i <= n; i++)
        //  dp[i] = dp[i - 1] + dp[i - 2];
        //return dp[n];

        // 56ms
        int a = 1, b = 1;
        while (n-- > 0)
        {
            a = (b += a) - a;
        }

        return a;
    }

    /// <summary>
    /// 71. Simplify Path
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public string SimplifyPath(string path)
    {
        Stack<string> stack = new Stack<string>();
        HashSet<string> skip = new HashSet<string> { "", ".", ".." };
        foreach (string dir in path.Split('/'))
        {
            if (dir == ".." && stack.Count > 0)
            {
                stack.Pop();
            }
            else if (!skip.Contains(dir))
            {
                stack.Push(dir);
            }
        }

        if (stack.Count == 0)
        {
            return "/";
        }

        StringBuilder sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Insert(0, "/" + stack.Pop());
        }

        return sb.ToString();
    }

    /// <summary>
    /// 73. Set Zeroes
    /// </summary>
    /// <param name="matrix"></param>
    public void SetZeroes(int[][] matrix)
    {
        int col0 = 1, rows = matrix.Length, cols = matrix[0].Length;
        // top-down
        for (int i = 0; i < rows; i++)
        {
            // first column
            if (matrix[i][0] == 0)
            {
                col0 = 0;
            }

            for (int j = 1; j < cols; j++)
            {
                // if the current cell is "0" set i row and j col as "0"
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = matrix[0][j] = 0;
                }
            }
        }

        // bottom-up
        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = cols - 1; j >= 1; j--)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }

            if (col0 == 0)
            {
                matrix[i][0] = 0;
            }
        }
    }

    /// <summary>
    /// 74. Search a 2D Matrix
    /// </summary>
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row = matrix.Length;
        if (row == 0)
        {
            return false;
        }

        int col = matrix[0].Length;
        int low = 0, high = row * col - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int r = mid / col;
            int c = mid % col;
            if (matrix[r][c] > target)
            {
                high = mid - 1;
            }
            else if (matrix[r][c] < target)
            {
                low = mid + 1;
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// 77.组合
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public IList<IList<int>> Combine(int n, int k)
    {
        List<int> temp = new List<int>();
        IList<IList<int>> ans = new List<IList<int>>();
        for (int i = 1; i <= k; ++i)
        {
            temp.Add(i);
        }

        temp.Add(n + 1);
        int j = 0;
        while (j < k)
        {
            ans.Add(new List<int>(temp.GetRange(0, k)));
            j = 0;
            while (j < k && temp[j] + 1 == temp[j + 1])
            {
                temp[j] = j + 1;
                ++j;
            }

            ++temp[j];
        }

        return ans;
    }

    /// <summary>
    /// 80. Remove Duplicates from Sorted Array II
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicatesV2(int[] nums)
    {
        int len = nums.Length;
        if (len <= 2)
        {
            return len;
        }

        int slow = 2, fast = 2;
        while (fast < len)
        {
            if (nums[slow - 2] != nums[fast])
            {
                nums[slow] = nums[fast];
                ++slow;
            }

            ++fast;
        }

        return slow;
    }

    /// <summary>
    /// 83. Remove Duplicates from Sorted List
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode current = head;
        while (current?.next != null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }

    /// <summary>
    /// 88. Merge Sorted Array
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="m"></param>
    /// <param name="num2"></param>
    /// <param name="n"></param>
    public void Merge(int[] num1, int m, int[] num2, int n)
    {
        int p = m - 1, q = n - 1, i = m + n - 1;
        while (q >= 0)
        {
            if (p < 0 || num2[q] >= num1[p])
            {
                num1[i--] = num2[q--];
            }
            else
            {
                num1[i--] = num1[p--];
            }
        }
    }

    /// <summary>
    /// 94. Binary Tree Inorder Traversal
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> ret = new List<int>();
        if (root == null)
        {
            return ret;
        }
        // recursively
        // InorderHelper(ret, root);

        // iteratively
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;
        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }

            curr = stack.Pop();
            ret.Add(curr.val);
            curr = curr.right;
        }

        return ret;

        // void InorderHelper(IList<int> data, TreeNode node)
        // {
        //     if (node == null)
        //     {
        //         return;
        //     }
        //     InorderHelper(data, node.left);
        //     data.Add(node.val);
        //     InorderHelper(data, node.right);
        // }
    }

    /// <summary>
    /// 98. Validate Binary Search Tree
    /// </summary>
    public bool IsValidBST(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        double inorder = -double.MaxValue;
        while (stack.Count > 0 || root != null)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            if (root.val <= inorder)
            {
                return false;
            }

            inorder = root.val;
            root = root.right;
        }

        return true;
    }

    /// <summary>
    /// 100. Same Tree
    /// </summary>
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null || q == null)
        {
            return p == q;
        }

        return p.val == q.val && IsSameTree(p.left, q.right) && IsSameTree(q.left, q.right);
    }

    /// <summary>
    /// 101. Symmetric Tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsSymmetric(TreeNode root)
    {
        // 116ms by recursion
        // return IsMirror(root, root);

        // 104ms by iteration
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode t1 = queue.Dequeue();
            TreeNode t2 = queue.Dequeue();
            if (t1 == null & t2 == null)
            {
                continue;
            }

            if (t1 == null || t2 == null)
            {
                return false;
            }

            if (t1.val != t2.val)
            {
                return false;
            }

            queue.Enqueue(t1.left);
            queue.Enqueue(t2.right);
            queue.Enqueue(t1.right);
            queue.Enqueue(t2.left);
        }

        return true;

        // bool IsMirror(TreeNode l1, TreeNode l2)
        // {
        //     if (l1 == null && l2 == null)
        //     {
        //         return true;
        //     }
        //
        //     if (l1 == null || l2 == null)
        //     {
        //         return false;
        //     }
        //
        //     return (l1.val == l2.val)
        //            && IsMirror(l1.left, l2.right)
        //            && IsMirror(l1.right, l2.left);
        // }
    }

    /// <summary>
    /// 104. Maximum Depth of Binary Tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepth(TreeNode root)
    {
        // DFS 112ms
        // return root == null ? 0 : 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        // BFS 112ms
        if (root == null)
        {
            return 0;
        }

        int res = 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            res++;
            for (int i = 0, n = queue.Count; i < n; i++)
            {
                TreeNode p = queue.Peek();
                queue.Dequeue();
                if (p.left != null)
                {
                    queue.Enqueue(p.left);
                }

                if (p.right != null)
                {
                    queue.Enqueue(p.right);
                }
            }
        }

        return res;
    }

    /// <summary>
    /// 107. Binary Tree Level Order Traversal II
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null)
        {
            return res;
        }

        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(root);
        while (true)
        {
            int nodeCount = que.Count;
            if (nodeCount == 0)
            {
                break;
            }

            List<int> subList = new List<int>();
            while (nodeCount > 0)
            {
                TreeNode dataNode = que.Dequeue();
                subList.Add(dataNode.val);
                if (dataNode.left != null)
                {
                    que.Enqueue(dataNode.left);
                }

                if (dataNode.right != null)
                {
                    que.Enqueue(dataNode.right);
                }

                nodeCount--;
            }

            res.Insert(0, subList);
        }

        return res;
    }

    /// <summary>
    /// 108. Convert Sorted Array To Binary Search Tree
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public TreeNode SortedArrayToBST(int[] nums)
    {
        //if (nums == null || nums.Length == 0) return null;
        //int mid = nums.Length / 2;
        //TreeNode root = new TreeNode(nums[mid]);
        //root.left = SubProcess(nums.Where((num, index) => index < mid).ToArray());
        //root.right = SubProcess(nums.Where((num, index) => index > mid).ToArray());
        //return root;
        return SubProcess(nums, 0, nums.Length - 1);

        TreeNode SubProcess(int[] data, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = start + (end - start) / 2;
            TreeNode root = new TreeNode(data[mid]) {
                left = SubProcess(data, start, mid - 1),
                right = SubProcess(data, mid + 1, end)
            };
            return root;
        }
    }

    /// <summary>
    /// 109. Convert Sorted List to Binary Search Tree
    /// </summary>
    public TreeNode SortedListToBST(ListNode head)
    {
        int size = FindSize(head);
        ListNode dummyHead = head;
        //Solution.head = head;
        return ConvertListToBST(0, size - 1);

        int FindSize(ListNode node)
        {
            ListNode ptr = node;
            int c = 0;
            while (ptr != null)
            {
                ptr = ptr.next;
                c += 1;
            }

            return c;
        }

        TreeNode ConvertListToBST(int l, int r)
        {
            if (l > r)
            {
                return null;
            }

            int mid = (l + r) / 2;
            TreeNode left = ConvertListToBST(l, mid - 1);
            TreeNode node = new TreeNode(head.val) {
                left = left
            };
            head = head.next;
            node.right = ConvertListToBST(mid + 1, r);
            return node;
        }
    }

    /// <summary>
    /// 110. Balanced Binary Tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsBalanced(TreeNode root)
    {
        return DFS(root) != -1;

        int DFS(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = DFS(node.left);
            if (leftHeight == -1)
            {
                return -1;
            }

            int rightHeight = DFS(node.right);
            if (rightHeight == -1)
            {
                return -1;
            }

            if (Math.Abs(leftHeight - rightHeight) > 1)
            {
                return -1;
            }

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }

    /// <summary>
    /// 111. Minimum Depth of Binary Tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int l = MinDepth(root.left), r = MinDepth(root.right);
        return 1 + (l < r && l > 0 || r < 1 ? l : r);
    }

    /// <summary>
    /// 112. Path Sum
    /// </summary>
    /// <param name="root"></param>
    /// <param name="sum"></param>
    /// <returns></returns>
    public bool HasPathSum(TreeNode root, int sum)
    {
        if (root == null)
        {
            return false;
        }

        if (root.val == sum && root.left == null && root.right == null)
        {
            return true;
        }

        return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
    }

    /// <summary>
    /// 113. 路径总和
    /// </summary>
    /// <param name="root"></param>
    /// <param name="targetSum"></param>
    /// <returns></returns>
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> path = new List<int>();
        Dfs(root, targetSum);
        return res;

        void Dfs(TreeNode node, int sum)
        {
            if (node is null)
            {
                return;
            }

            path.Add(node.val);
            sum -= node.val;
            if (node.left is null && node.right is null && sum == 0)
            {
                res.Add(new List<int>(path));
            }

            Dfs(node.left, sum);
            Dfs(node.right, sum);
            path.RemoveAt(path.Count - 1);
        }
    }

    /// <summary>
    /// 116. Populating Next Right Pointers in Each Node
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public BinaryTreeNode Connect(BinaryTreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        BinaryTreeNode leftmost = root;
        while (leftmost.Left != null)
        {
            BinaryTreeNode head = leftmost;
            while (head != null)
            {
                head.Left.Next = head.Right;
                if (head.Next != null)
                {
                    head.Right.Next = head.Next.Left;
                }

                head = head.Next;
            }

            leftmost = leftmost.Left;
        }

        return root;
    }

    /// <summary>
    /// 118. Pascal's triangle
    /// </summary>
    /// <param name="numRows"></param>
    /// <returns></returns>
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = new List<IList<int>>();
        //if (numRows == 0) return triangle;
        //triangle.Add(new List<int>());
        //triangle[0].Add(1);
        //for(int rowNum = 1; rowNum < numRows; rowNum++)
        //{
        //    List<int> row = new List<int>();
        //    IList<int> prevRow = triangle[rowNum - 1];
        //    row.Add(1);
        //    for (int j = 1; j < rowNum; j++) row.Add(prevRow[j - 1] + prevRow[j]);
        //    row.Add(1);
        //    triangle.Add(row);
        //}
        for (int i = 0; i < numRows; ++i)
        {
            IList<int> row = new List<int>();
            for (int r = 1; r <= i + 1; r++)
            {
                row.Add(1);
            }

            triangle.Add(row);
            for (int j = 1; j < i; ++j)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        return triangle;
    }

    /// <summary>
    /// 120. Triangle
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        int n = triangle.Count;
        int[] f = new int[n];
        f[0] = triangle[0][0];
        for (int i = 1; i < n; ++i)
        {
            f[i] = f[i - 1] + triangle[i][i];
            for (int j = i - 1; j > 0; --j)
            {
                f[j] = Math.Min(f[j - 1], f[j]) + triangle[i][j];
            }

            f[0] += triangle[i][0];
        }

        return f.Min();
    }

    /// <summary>
    /// 121. Best Time to Buy and Sell Stock
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public int MaxProfit(int[] prices)
    {
        // 108 ms
        //int total = 0;
        //for (int i = 1; i < prices.Length; i++)
        //    if (prices[i] > prices[i - 1])
        //        total += prices[i] - prices[i - 1];
        //return total;
        int len = prices.Length;
        if (len < 1)
        {
            return 0;
        }

        int[] full = new int[len];
        int[] empty = new int[len];
        empty[0] = 0;
        full[0] = prices[0] * -1;
        for (int i = 1; i < len; i++)
        {
            empty[i] = Math.Max(empty[i - 1], full[i - 1] + prices[i]);
            full[i] = Math.Max(full[i - 1], empty[i - 1] - prices[i]);
        }

        return Math.Max(full[len - 1], empty[len - 1]);
    }

    /// <summary>
    /// 125. Valid Palindrome
    /// </summary>
    public bool IsPalindrome(string s)
    {
        for (int i = 0, j = s.Length - 1; i < j;)
        {
            if (!char.IsLetterOrDigit(s[i])) // skip space from head
            {
                i++;
            }
            else if (!char.IsLetterOrDigit(s[j])) // skip space from tail
            {
                j--;
            }
            else if (char.ToLower(s[i++]) != char.ToLower(s[j--]))
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// 136. Single Number
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SingleNumber(int[] nums)
    {
        return nums.Aggregate(0, (current, item) => current ^ item);
    }

    /// <summary>
    /// 137. Single Number II
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public int SingleNumberII(int[] A)
    {
        int ones = 0, twos = 0;
        foreach (int t in A)
        {
            ones = (ones ^ t) & ~twos;
            twos = (twos ^ t) & ~ones;
        }

        return ones;
    }

    /// <summary>
    /// 141. Linked List Cycle
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool HasCycle(ListNode head)
    {
        if (head?.next == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head.next;
        while (slow != fast)
        {
            if (fast?.next == null)
            {
                return false;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return true;
    }

    /// <summary>
    /// 144. Binary Tree Preorder Traversal
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (root != null)
        {
            res.Add(root.val);
            if (root.right != null)
            {
                stack.Push(root.right);
            }

            root = root.left;
            if (root == null && stack.Count > 0)
            {
                root = stack.Pop();
            }
        }

        return res;
    }

    /// <summary>
    /// 148. Sort List
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode SortList(ListNode head)
    {
        if (head?.next == null)
        {
            return head;
        }

        ListNode prev = null, left = head, right = head;
        while (right?.next != null)
        {
            prev = left;
            left = left.next;
            right = right.next.next;
        }

        prev.next = null;

        ListNode l1 = SortList(head);
        ListNode l2 = SortList(left);

        return MergeTwoLists(l1, l2);
    }

    /// <summary>
    /// 153. Find Minimum in Rotated Sorted Array
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMin(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        int l = 0, r = nums.Length - 1;
        if (nums[r] > nums[0])
        {
            return nums[0];
        }

        while (r >= l)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] > nums[mid + 1])
            {
                return nums[mid + 1];
            }

            if (nums[mid - 1] > nums[mid])
            {
                return nums[mid];
            }

            if (nums[mid] > nums[0])
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return -1;
    }

    /// <summary>
    /// 162. Find Peak Element
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindPeakElement(int[] nums)
    {
        int len = nums.Length;
        int l = 0, r = len - 1, ans = -1;
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (Compare(nums, mid - 1, mid) < 0 &&
                Compare(nums, mid, mid + 1) > 0)
            {
                ans = mid;
                break;
            }

            if (Compare(nums, mid, mid + 1) < 0)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return ans;

        int[] Get(int[] data, int index)
        {
            if (index == -1 || index == data.Length)
            {
                return new[] { 0, 0 };
            }

            return new[] { 1, data[index] };
        }

        int Compare(int[] data, int index1, int index2)
        {
            int[] num1 = Get(data, index1);
            int[] num2 = Get(data, index2);
            if (num1[0] != data[0])
            {
                return num1[0] > num2[0] ? 1 : -1;
            }

            if (num1[1] == num2[1])
            {
                return 0;
            }

            return num1[1] > num2[1] ? 1 : -1;
        }
    }

    /// <summary>
    /// 167. Two Sum II - Input array is sorted
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSumII(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return new int[] { left + 1, right + 1 };
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return new[] { -1, -1 };
    }

    /// <summary>
    /// 168. Excel Sheet Column Title
    /// </summary>
    /// <param name="columnNumber"></param>
    /// <returns></returns>
    public string ConvertToTitle(int columnNumber)
    {
        StringBuilder sb = new StringBuilder();
        while (columnNumber != 0)
        {
            columnNumber--;
            sb.Append((char)(columnNumber % 26 + 'A'));
            columnNumber /= 26;
        }
        StringBuilder columnTitle = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            columnTitle.Append(sb[i]);
        }
        return columnTitle.ToString();
    }

    /// <summary>
    /// 169. Majority Element
    /// </summary>
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = 0;
        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += num == candidate ? 1 : -1;
        }

        return candidate;
    }

    /// <summary>
    /// 171. Excel Sheet Column Number
    /// </summary>
    /// <param name="columnTitle"></param>
    /// <returns></returns>
    public int TitleToNumber(string columnTitle)
    {
        int number = 0;
        int multiple = 1;
        for (int i = columnTitle.Length - 1; i >= 0; --i)
        {
            int k = columnTitle[i] - 'A' + 1;
            number += k * multiple;
            multiple *= 26;
        }
        return number;
    }

    /// <summary>
    /// 172. Factorial Trailing Zeroes
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int TrailingZeroes(int n)
    {
        return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
    }

    /// <summary>
    /// 174. Dungeon Game
    /// </summary>
    /// <param name="dungeon">map</param>
    /// <returns></returns>
    public int CalculateMinimumHP(int[,] dungeon)
    {
        if (dungeon == null || dungeon.GetLength(0) == 0 || dungeon.GetLength(1) == 0)
        {
            return 0;
        }

        int m = dungeon.GetLength(0);
        int n = dungeon.GetLength(1);
        int[,] health = new int[m, n];
        health[m - 1, n - 1] = Math.Max(1 - dungeon[m - 1, n - 1], 1);
        for (int i = m - 2; i >= 0; i--)
        {
            health[i, n - 1] = Math.Max(health[i + 1, n - 1] - dungeon[i, n - 1], 1);
        }

        for (int j = n - 2; j >= 0; j--)
        {
            health[m - 1, j] = Math.Max(health[m - 1, j + 1] - dungeon[m - 1, j], 1);
        }

        for (int i = m - 2; i >= 0; i--)
        {
            for (int j = n - 2; j >= 0; j--)
            {
                int down = Math.Max(health[i + 1, j] - dungeon[i, j], 1);
                int right = Math.Max(health[i, j + 1] - dungeon[i, j], 1);
                health[i, j] = Math.Min(right, down);
            }
        }

        return health[0, 0];
    }

    /// <summary>
    /// 189. Rotate Array
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);

        void Reverse(int[] data, int start, int end)
        {
            while (start < end)
            {
                (data[start], data[end]) = (data[end], data[start]);
                start++;
                end--;
            }
        }
    }

    /// <summary>
    /// 190. Reverse Bits
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public uint ReverseBits(uint n)
    {
        n = (n >> 16) | (n << 16);
        n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
        n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
        n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);
        n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);
        return n;
        //if (n == 0) return 0;
        //uint res = 0;
        //for (int i = 0; i < 32; i++)
        //{
        //    res <<= 1;
        //    if ((n & 1) == 1) res++;
        //    n >>= 1;
        //}
        //return res;
    }

    /// <summary>
    /// 191. Number of 1 Bits
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int HammingWeight(uint n)
    {
        int res = 0;
        while (n != 0)
        {
            n &= (n - 1);
            res++;
        }

        return res;
    }

    /// <summary>
    /// 198. House Robber
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int Rob(int[] nums)
    {
        //int a = 0;
        //int b = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (i % 2 == 0)
        //        a = Math.Max(a + nums[i], b);
        //    else
        //        b = Math.Max(a, b + nums[i]);
        //}
        //return Math.Max(a, b);

        int rob = 0;
        int notRob = 0;
        foreach (int item in nums)
        {
            int current = notRob + item;
            notRob = Math.Max(notRob, rob);
            rob = current;
        }

        return Math.Max(notRob, rob);
    }

    /// <summary>
    /// 202. Happy Number
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool IsHappy(int n)
    {
        int slow = n, fast = n;
        while (slow != 1)
        {
            slow = DigitSquareSum(slow);
            fast = DigitSquareSum(DigitSquareSum(fast));
            if (slow != 1 && slow == fast)
            {
                return false;
            }
        }

        return true;

        int DigitSquareSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int tmp = num % 10;
                sum += tmp * tmp;
                num /= 10;
            }

            return sum;
        }
    }

    /// <summary>
    /// 204. Count Primes
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int CountPrimes(int n)
    {
        if (n < 3)
        {
            return 0;
        }

        bool[] f = new bool[n];
        int count = n / 2;
        for (int i = 3; i * i < n; i += 2)
        {
            if (f[i])
            {
                continue;
            }

            for (int j = i * i; j < n; j += 2 * i)
            {
                if (f[j])
                {
                    continue;
                }

                --count;
                f[j] = true;
            }
        }

        return count;
    }

    /// <summary>
    /// 205. Isomorphic Strings
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsIsomorphic(string s, string t)
    {
        int[] m1 = new int[256];
        int[] m2 = new int[256];
        int n = s.Length;
        for (int i = 0; i < 256; i++)
        {
            m1[i] = m2[i] = -1;
        }

        for (int i = 0; i < n; i++)
        {
            if (m1[s[i]] != m2[t[i]])
            {
                return false;
            }

            m1[s[i]] = m2[t[i]] = i;
        }

        return true;
    }

    /// <summary>
    /// 206. Reverse Linked List
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode ReverseList(ListNode head)
    {
        // Iteratively Time: O(n) Space O(1)
        ListNode prev = null;
        ListNode curr = head;
        while (curr is not null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;

        // Recursively Time: O(n) Space O(n)
        //if (head is null || head.next is null)
        //{
        //    return head;
        //}
        //ListNode newHead = ReverseList(head.next);
        //head.next.next = head;
        //head.next = null;
        //return newHead;
    }

    /// <summary>
    /// 212. Word Search II
    /// </summary>
    /// <param name="board"></param>
    /// <param name="words"></param>
    /// <returns></returns>
    public IList<string> FindWords(char[,] board, string[] words)
    {
        IList<string> res = new List<string>();
        TrieNode root = BuildTrie(words);
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Dfs(board, i, j, root, res);
            }
        }

        return res;

        void Dfs(char[,] dataBoard, int i, int j, TrieNode p, IList<string> list)
        {
            char c = dataBoard[i, j];
            if (c == '#' || p.Get(c) == null)
            {
                return;
            }

            p = p.Get(c);
            if (p.Word != null)
            {
                list.Add(p.Word);
                p.Word = null;
            }

            dataBoard[i, j] = '#';
            if (i > 0)
            {
                Dfs(dataBoard, i - 1, j, p, list);
            }

            if (j > 0)
            {
                Dfs(dataBoard, i, j - 1, p, list);
            }

            if (i < dataBoard.GetLength(0) - 1)
            {
                Dfs(dataBoard, i + 1, j, p, list);
            }

            if (j < dataBoard.GetLength(1) - 1)
            {
                Dfs(dataBoard, i, j + 1, p, list);
            }

            dataBoard[i, j] = c;
        }

        TrieNode BuildTrie(string[] wordData)
        {
            TrieNode node = new TrieNode();
            foreach (string item in wordData)
            {
                TrieNode p = node;
                foreach (char ch in item)
                {
                    if (p.Get(ch) == null)
                    {
                        p.Links[ch - 'a'] = new TrieNode();
                    }

                    p = p.Get(ch);
                }

                p.Word = item;
            }

            return node;
        }
    }

    /// <summary>
    /// 213. House Robber II
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RobII(int[] nums)
    {
        int n = nums.Length;
        if (n < 2)
        {
            return n == 1 ? nums[0] : 0;
        }

        return Math.Max(Robber(nums, 0, n - 2), Robber(nums, 1, n - 1));

        int Robber(int[] data, int l, int r)
        {
            int pre = 0, cur = 0;
            for (int i = l; i <= r; i++)
            {
                int temp = Math.Max(pre + data[i], cur);
                pre = cur;
                cur = temp;
            }

            return cur;
        }
    }

    /// <summary>
    /// 217. Contains Duplicate
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool ContainsDuplicate(int[] nums)
    {
        ISet<int> set = new HashSet<int>();
        foreach (int item in nums)
        {
            if (!set.Add(item))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// 231. Power of Two
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool IsPowerOfTwo(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }

    /// <summary>
    /// 234.回文链表
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool IsPalindrome(ListNode head)
    {
        if (head == null)
        {
            return true;
        }

        ListNode firstHalfEnd = EndOfFirstHalf(head);
        ListNode secondHalfStart = ReverseList(firstHalfEnd.next);
        ListNode p1 = head;
        ListNode p2 = secondHalfStart;
        while (p2 != null)
        {
            if (p1.val != p2.val)
            {
                return false;
            }

            p1 = p1.next;
            p2 = p2.next;
        }

        firstHalfEnd.next = ReverseList(secondHalfStart);
        return true;

        ListNode ReverseList(ListNode node)
        {
            ListNode prev = null;
            ListNode curr = node;
            while (curr != null)
            {
                ListNode tmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmp;
            }

            return prev;
        }

        ListNode EndOfFirstHalf(ListNode node)
        {
            ListNode fast = node;
            ListNode slow = node;
            while (fast.next?.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }
    }

    /// <summary>
    /// 242. Valid Anagram
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] tables = new int[26];
        foreach (char c in s)
        {
            tables[c - 'a']++;
        }

        foreach (char c in t)
        {
            tables[c - 'a']--;
        }

        return tables.All(e => e == 0);
    }

    /// <summary>
    /// 258.各位相加
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int AddDigits(int num)
    {
        return (num - 1) % 9 + 1;
    }

    /// <summary>
    /// 260. Single Number III
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SingleNumberIII(int[] nums)
    {
        int xorSum = nums.Aggregate(0, (current, num) => current ^ num);
        int lsb = (xorSum == int.MinValue ? xorSum : xorSum & (-xorSum));
        int type1 = 0, type2 = 0;
        foreach (int num in nums)
        {
            if ((num & lsb) != 0)
            {
                type1 ^= num;
            }
            else
            {
                type2 ^= num;
            }
        }

        return new[] { type1, type2 };
    }

    /// <summary>
    /// 268. Missing Number
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MissingNumber(int[] nums)
    {
        int len = nums.Length;
        int sum = len * (len + 1) / 2;
        int actual = nums.Sum();
        return sum - actual;
    }

    /// <summary>
    /// 283. Move Zeroes
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public void MoveZeroes(int[] nums)
    {
        //int j = 0, len = nums.Length;
        //for (int i = 0; i < len; i++)
        //    if (nums[i] != 0)
        //        nums[j++] = nums[i];
        //for (; j < len; j++)
        //    nums[j] = 0;

        int len = nums.Length, left = 0, right = 0;
        while (right < len)
        {
            if (nums[right] != 0)
            {
                Utilities.Swap(nums, left, right);
                left++;
            }

            right++;
        }
    }

    /// <summary>
    /// 287. Find the Duplicate Number
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindDuplicate(int[] nums)
    {
        int slow = 0, fast = 0;
        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (slow != fast);

        slow = 0;
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }

    /// <summary>
    /// 337. House Robber III 
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int RobIII(TreeNode root)
    {
        int[] res = SubRob(root);
        return Math.Max(res[0], res[1]);

        int[] SubRob(TreeNode node)
        {
            if (node == null)
            {
                return new int[2];
            }

            int[] left = SubRob(node.left);
            int[] right = SubRob(node.right);
            int[] ret = new int[2];
            ret[0] = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
            ret[1] = node.val + left[0] + right[0];
            return ret;
        }
    }

    /// <summary>
    /// 342. Power of Four
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public bool IsPowerOfFour(int num)
    {
        return num > 0 && (num & (num - 1)) == 0 && (num - 1) % 3 == 0;
    }

    /// <summary>
    /// 344. Reverse String
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public void ReverseString(char[] s)
    {
        int len = s.Length;
        for (int left = 0, right = len - 1; left < right; ++left, --right)
        {
            Utilities.Swap(s, left, right);
        }
    }

    /// <summary>
    /// 357. 统计各位数字都不同的数字个数
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int CountNumbersWithUniqueDigits(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        if (n == 1)
        {
            return 10;
        }

        int res = 10, cur = 9;
        for (int i = 0; i < n - 1; i++)
        {
            cur *= 9 - i;
            res += cur;
        }

        return res;
    }

    /// <summary>
    /// 371. Sum of Two Integers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetSum(int a, int b)
    {
        while (b != 0)
        {
            int carry = (a & b) << 1;
            a ^= b;
            b = carry;
        }

        return a;
    }

    /// <summary>
    /// 374. Guess Number Higher or Lower
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int GuessNumber(int n)
    {
        int left = 1, right = n;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int res = Guess(mid);
            switch (res)
            {
                case 0:
                    return mid;
                case < 0:
                    right = mid - 1;
                    break;
                default:
                    left = mid + 1;
                    break;
            }
        }

        return -1;

        int Guess(int num)
        {
            Random random = new Random();
            int target = random.Next(1, int.MaxValue);
            if (num > target)
            {
                return 1;
            }
            else if (num < target)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }

    /// <summary>
    /// 386. 字典序排数
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<int> LexicalOrder(int n)
    {
        IList<int> list = new List<int>(n);
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            list.Add(num);
            if (num * 10 <= n)
            {
                num *= 10;
            }
            else
            {
                while (num % 10 == 9 || num + 1 > n)
                {
                    num /= 10;
                }

                num++;
            }
        }

        return list;
    }

    /// <summary>
    /// 393. UTF-8 Validation
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public bool ValidUtf8(int[] data)
    {
        const int mask1 = 1 << 7;
        const int mask2 = (1 << 7) + (1 << 6);
        int m = data.Length;
        int index = 0;
        while (index < m)
        {
            int num = data[index];
            int n = GetBytes(num);
            if (n < 0 || index + n > m)
            {
                return false;
            }

            for (int i = 1; i < n; i++)
            {
                if (!IsValid((data[index + i])))
                {
                    return false;
                }
            }

            index += n;
        }

        return true;

        int GetBytes(int num)
        {
            if ((num & mask1) == 0)
            {
                return 1;
            }

            int n = 0;
            int mask = mask1;
            while ((num & mask) != 0)
            {
                n++;
                if (n > 4)
                {
                    return -1;
                }

                mask >>= 1;
            }

            return n >= 2 ? n : -1;
        }

        bool IsValid(int num)
        {
            return (num & mask2) == mask1;
        }
    }

    /// <summary>
    /// 396. 旋转函数
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxRotateFunction(int[] nums)
    {
        int n = nums.Length;
        if (n <= 1)
        {
            return 0;
        }

        int f = 0, numSum = nums.Sum();
        for (int i = 0; i < n; i++)
        {
            f += i * nums[i];
        }

        int ans = f;
        for (int i = n - 1; i > 0; i--)
        {
            f += numSum - n * nums[i];
            ans = Math.Max(ans, f);
        }

        return ans;
    }

    /// <summary>
    /// 401. Binary Watch
    /// </summary>
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        IList<string> ans = new List<string>();
        for (int i = 0; i < 1024; ++i)
        {
            int h = i >> 6, m = i & 63;
            if (h < 12 && m < 60 && BitCount(i) == turnedOn)
            {
                ans.Add(h + ":" + (m < 10 ? "0" : "") + m);
            }
        }

        return ans;

        int BitCount(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i = i + (i >> 8);
            i = i + (i >> 16);
            return i & 0x3f;
        }
    }

    /// <summary>
    /// 412. Fizz Buzz
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<string> FizzBuzz(int n)
    {
        IList<string> answer = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            StringBuilder sb = new StringBuilder();
            if (i % 3 == 0)
            {
                sb.Append("Fizz");
            }

            if (i % 5 == 0)
            {
                sb.Append("Buzz");
            }

            if (sb.Length == 0)
            {
                sb.Append(i);
            }

            answer.Add(sb.ToString());
        }

        return answer;
    }

    /// <summary>
    /// 415. Add Strings
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string AddStrings(string num1, string num2)
    {
        int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
        StringBuilder ans = new StringBuilder();
        while (i >= 0 || j >= 0 || carry != 0)
        {
            int x = i >= 0 ? num1[i] - '0' : 0;
            int y = j >= 0 ? num2[j] - '0' : 0;
            int result = x + y + carry;
            ans.Append(result % 10);
            carry = result / 10;
            i--;
            j--;
        }

        return new string(ans.ToString().Reverse().ToArray());
    }

    /// <summary>
    /// 429. N-ary Tree Level Order Traversal
    /// </summary>
    public IList<IList<int>> LevelOrder(Node root)
    {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null)
        {
            return res;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Any())
        {
            int size = queue.Count;
            IList<int> tmp = new List<int>();
            for (int i = 0; i < size; i++)
            {
                Node curr = queue.Peek();
                tmp.Add(curr.val);
                foreach (Node child in curr.children)
                {
                    queue.Enqueue(child);
                }

                queue.Dequeue();
            }

            res.Add(tmp);
        }

        return res;
    }

    /// <summary>
    /// 434. Number of Segments in a String
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int CountSegments(string s)
    {
        return s.Where((t, i) => (i == 0 || s[i - 1] == ' ') && t != ' ').Count();
    }

    /// <summary>
    /// 450. Delete Node in a BST
    /// </summary>
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
        {
            return null;
        }

        if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            if (root.left == null)
            {
                return root.right;
            }

            if (root.right == null)
            {
                return root.left;
            }

            TreeNode minNode = FindMin(root.right);
            root.val = minNode.val;
            root.right = DeleteNode(root.right, root.val);
        }

        return root;

        TreeNode FindMin(TreeNode node)
        {
            while (node.left != null)
            {
                node = node.left;
            }

            return node;
        }
    }

    /// <summary>
    /// 459. Repeated Substring Pattern
    /// </summary>
    /// <param name="s">input string</param>
    /// <returns></returns>
    public bool RepeatedSubstring(string s)
    {
        int n = s.Length;
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i != 0)
            {
                continue;
            }

            sb.Clear();
            string sub = s[..i];
            while (sb.Length < n)
            {
                sb.Append(sub);
            }

            if (sb.ToString().Equals(s))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// 462. Minimum Moves to Equal Array Elements II
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinMove2(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length;
        int mid = nums[n / 2];
        return nums.Sum(x => Math.Abs(x - mid));
    }

    /// <summary>
    /// 463. IsLand Perimeter
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int IsLandPerimeter(int[,] grid)
    {
        int island = 0;
        int neighbor = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.GetLength(1) - 1; j++)
            {
                if (grid[i, j] != 1)
                {
                    continue;
                }

                island++;
                if (i < grid.Length - 1 && grid[i, j + 1] == 1)
                {
                    neighbor++;
                }

                if (j < grid.GetLength(1) - 1 && grid[i, j] == 1)
                {
                    neighbor++;
                }
            }
        }

        return island * 4 - neighbor * 2;
    }

    /// <summary>
    /// 467. Unique Substrings in Wraparound String
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    public int FindSubstringInWraparoundString(string p)
    {
        int[] dp = new int[26];
        int k = 0;
        for (int i = 0; i < p.Length; ++i)
        {
            if (i > 0 && (p[i] - p[i - 1] + 26) % 26 == 1)
            {
                ++k;
            }
            else
            {
                k = 1;
            }

            dp[p[i] - 'a'] = Math.Max(dp[p[i] - 'a'], k);
        }

        return dp.Sum();
    }
    
    /// <summary>
    /// 468. Valid IP Address
    /// </summary>
    /// <param name="queryIP"></param>
    /// <returns></returns>
    public string ValidIPAddress(string queryIP)
    {
        if (queryIP.Count(c => c == '.') == 3)
        {
            return ValidIPv4(queryIP);
        }
        else if (queryIP.Count(c => c == ':') == 7)
        {
            return ValidIPv6(queryIP);
        }
        else
        {
            return "Neither";
        }

        string ValidIPv4(string IP)
        {
            string[] chunks = IP.Split('.');
            foreach (string chunk in chunks)
            {
                if (chunk.Length is 0 or > 3)
                {
                    return "Neither";
                }

                if (chunk[0] == '0' && chunk.Length != 1)
                {
                    return "Neither";
                }

                if (chunk.Any(c => !char.IsNumber(c)))
                {
                    return "Neither";
                }

                if (System.Convert.ToInt32(chunk) > 255)
                {
                    return "Neither";
                }
            }

            return "IPv4";
        }

        string ValidIPv6(string IP)
        {
            string[] chunks = IP.Split(':');
            const string hexDigits = "0123456789abcdefABCDEF";
            foreach (string chunk in chunks)
            {
                if (chunk.Length is 0 or > 4)
                {
                    return "Neither";
                }

                if (chunk.Any(c => !hexDigits.Contains(c)))
                {
                    return "Neither";
                }
            }

            return "IPv6";
        }
    }

    /// <summary>
    /// 477.Total Hamming Distance
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int TotalHammingDistance(int[] nums)
    {
        int size = nums.Length;
        int res = 0;
        for (int i = 0; i < 30; i++)
        {
            int tmp = nums.Sum(num => (num >> i) & 1);
            res += tmp * (size - tmp);
        }

        return res;
    }

    /// <summary>
    /// 498.对角线遍历
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int[] FindDiagonalOrder(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0)
        {
            return Array.Empty<int>();
        }

        int N = matrix.Length;
        int M = matrix[0].Length;
        int row = 0, col = 0;
        int direction = 1;
        int[] res = new int[N * M];
        int r = 0;
        while (row < N && col < M)
        {
            res[r++] = matrix[row][col];
            int newRow = row + (direction == 1 ? -1 : 1);
            int newCol = col + (direction == 1 ? 1 : -1);
            if (newRow < 0 || newRow == N || newCol < 0 || newCol == M)
            {
                if (direction == 1)
                {
                    row += (col == M - 1 ? 1 : 0);
                    col += (col < M - 1 ? 1 : 0);
                }
                else
                {
                    col += (row == N - 1 ? 1 : 0);
                    row += (row < N - 1 ? 1 : 0);
                }

                direction = 1 - direction;
            }
            else
            {
                row = newRow;
                col = newCol;
            }
        }

        return res;
    }

    /// <summary>
    /// 504.7进制数
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public string ConvertToBase7(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        bool negative = num < 0;
        num = Math.Abs(num);
        StringBuilder digits = new StringBuilder();
        while (num > 0)
        {
            digits.Append(num % 7);
            num /= 7;
        }

        if (negative)
        {
            digits.Append('-');
        }

        string res = digits.ToString();
        return string.Create(res.Length, res, (chars, state) => {
            state.AsSpan().CopyTo(chars);
            chars.Reverse();
        });
    }

    /// <summary>
    /// 509. Fibonacci Number
    /// </summary>
    public int Fib(int N)
    {
        if (N < 2)
        {
            return N;
        }

        int f0 = 0;
        int f1 = 1;
        int res = 0;
        for (int i = 1; i < N; i++)
        {
            res = f0 + f1;
            f0 = f1;
            f1 = res;
        }

        return res;
    }

    /// <summary>
    /// 521.最长特殊序列
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int FindLUSLength(string a, string b)
    {
        return a == b ? -1 : Math.Max(a.Length, b.Length);
    }

    /// <summary>
    /// 537.复数乘法
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string ComplexNumberMultiply(string num1, string num2)
    {
        string[] complex1 = num1.Split('+', 'i');
        string[] complex2 = num2.Split('+', 'i');
        int real1 = int.Parse(complex1[0]);
        int real2 = int.Parse(complex2[0]);
        int imag1 = int.Parse(complex1[1]);
        int imag2 = int.Parse(complex2[1]);
        return $"{real1 * real2 - imag1 * imag2}+{real1 * imag2 + imag1 * real2}i";
    }

    /// <summary>
    /// 540.有序数组中的单一元素
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SingleNonDuplicate(int[] nums)
    {
        int low = 0, high = nums.Length - 1;
        while (low < high)
        {
            int mid = (high - low) / 2 + low;
            if (nums[mid] == nums[mid ^ 1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return nums[low];
    }

    /// <summary>
    /// 542. 01 Matrix
    /// </summary>
    /// <param name="mat"></param>
    /// <returns></returns>
    public int[][] UpdateMatrix(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        int[][] dist = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dist[i] = new int[n];
            Array.Fill(dist[i], int.MaxValue / 2);
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 0)
                {
                    dist[i][j] = 0;
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i - 1 >= 0)
                {
                    dist[i][j] = Math.Min(dist[i][j], dist[i - 1][j] + 1);
                }

                if (j - 1 >= 0)
                {
                    dist[i][j] = Math.Min(dist[i][j], dist[i][j - 1] + 1);
                }
            }
        }

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                if (i + 1 < m)
                {
                    dist[i][j] = Math.Min(dist[i][j], dist[i + 1][j] + 1);
                }

                if (j + 1 < n)
                {
                    dist[i][j] = Math.Min(dist[i][j], dist[i][j + 1] + 1);
                }
            }
        }

        return dist;
    }

    /// <summary>
    /// 553.最优除法
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public string OptimalDivision(int[] nums)
    {
        int n = nums.Length;
        switch (n)
        {
            case 1:
                return nums[0].ToString();
            case 2:
                return $"{nums[0]}/{nums[1]}";
        }

        StringBuilder res = new StringBuilder();
        res.Append(nums[0]);
        res.Append("/(");
        res.Append(nums[1]);
        for (int i = 2; i < n; i++)
        {
            res.Append('/');
            res.Append(nums[i]);
        }

        res.Append(')');
        return res.ToString();
    }

    /// <summary>
    /// 557. Reverse Words in a String III
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ReverseWords(string s)
    {
        StringBuilder sb = new StringBuilder();
        int len = s.Length;
        int i = 0;
        while (i < len)
        {
            int start = i;
            while (i < len && s[i] != ' ')
            {
                i++;
            }

            for (int p = start; p < i; p++)
            {
                sb.Append(s[start + i - 1 - p]);
            }

            while (i < len && s[i] == ' ')
            {
                i++;
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }

    /// <summary>
    /// 567. Permutation in String
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool CheckInclusion(string s1, string s2)
    {
        int n = s1.Length, m = s2.Length;
        if (n > m)
        {
            return false;
        }

        int[] cnt = new int[26];
        for (int i = 0; i < n; i++)
        {
            --cnt[s1[i] - 'a'];
            ++cnt[s2[i] - 'a'];
        }

        int diff = cnt.Count(item => item != 0);
        if (diff == 0)
        {
            return true;
        }

        for (int i = n; i < m; i++)
        {
            int x = s2[i] - 'a', y = s2[i - n] - 'a';
            if (x == y)
            {
                continue;
            }

            if (cnt[x] == 0)
            {
                ++diff;
            }

            ++cnt[x];
            if (cnt[x] == 0)
            {
                --diff;
            }

            if (cnt[y] == 0)
            {
                ++diff;
            }

            --cnt[y];
            if (cnt[y] == 0)
            {
                --diff;
            }

            if (diff == 0)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// 589.N叉树的前序遍历
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> PreOrder(Node root)
    {
        IList<int> ans = new List<int>();
        Dfs(root);
        return ans;

        void Dfs(Node node)
        {
            if (node is null)
            {
                return;
            }

            ans.Add(node.val);
            foreach (Node ch in node.children)
            {
                Dfs(ch);
            }
        }
    }

    /// <summary>
    /// 590.N叉树的后序遍历
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> PostOrder(Node root)
    {
        IList<int> ans = new List<int>();
        Dfs(root);
        return ans;

        void Dfs(Node node)
        {
            if (node is null)
            {
                return;
            }

            foreach (Node ch in node.children)
            {
                Dfs(ch);
            }

            ans.Add(node.val);
        }
    }

    /// <summary>
    /// 599.两个列表的最小索引和
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        Dictionary<string, int> index = new Dictionary<string, int>();
        for (int i = 0; i < list1.Length; i++)
        {
            index.Add(list1[i], i);
        }

        IList<string> ret = new List<string>();
        int indexSum = int.MaxValue;
        for (int i = 0; i < list2.Length; i++)
        {
            if (!index.ContainsKey(list2[i]))
            {
                continue;
            }

            int j = index[list2[i]];
            if (i + j < indexSum)
            {
                ret.Clear();
                ret.Add(list2[i]);
                indexSum = i + j;
            }
            else if (i + j == indexSum)
            {
                ret.Add(list2[i]);
            }
        }

        return ret.ToArray();
    }

    /// <summary>
    /// 617. Merge Two Binary Trees
    /// </summary>
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
    {
        // Recursive
        // if(t1 == null)
        //     return t2;
        // if(t2 == null)
        //     return t1;
        // t1.val += t2.val;
        // t1.left = MergeTrees(t1.left, t2.left);
        // t1.right = MergeTrees(t1.right, t2.right);
        // return t1;
        // Iterative
        if (t1 == null)
        {
            return t2;
        }

        Stack<TreeNode[]> stack = new Stack<TreeNode[]>();
        stack.Push(new[] { t1, t2 });
        while (stack.Count > 0)
        {
            TreeNode[] t = stack.Pop();
            if (t[0] == null || t[1] == null)
            {
                continue;
            }

            t[0].val += t[1].val;
            if (t[0].left == null)
            {
                t[0].left = t[1].left;
            }
            else
            {
                stack.Push(new[] { t[0].left, t[1].left });
            }

            if (t[0].right == null)
            {
                t[0].right = t[1].right;
            }
            else
            {
                stack.Push(new[] { t[0].right, t[1].right });
            }
        }

        return t1;
    }

    /// <summary>
    /// 653.两数之和 IV
    /// </summary>
    /// <param name="root"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool FindTarget(TreeNode root, int k)
    {
        TreeNode GetLeft(Stack<TreeNode> stack)
        {
            TreeNode root = stack.Pop();
            TreeNode node = root.right;
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }

            return root;
        }

        TreeNode GetRight(Stack<TreeNode> stack)
        {
            TreeNode root = stack.Pop();
            TreeNode node = root.left;
            while (node != null)
            {
                stack.Push(node);
                node = node.right;
            }

            return root;
        }

        TreeNode left = root, right = root;
        Stack<TreeNode> leftStack = new Stack<TreeNode>();
        Stack<TreeNode> rightStack = new Stack<TreeNode>();
        leftStack.Push(left);
        while (left.left != null)
        {
            leftStack.Push(left.left);
            left = left.left;
        }

        rightStack.Push(right);
        while (right.right != null)
        {
            rightStack.Push(right.right);
            right = right.right;
        }

        while (left != right)
        {
            if (left.val + right.val == k)
            {
                return true;
            }

            if (left.val + right.val < k)
            {
                left = GetLeft(leftStack);
            }
            else
            {
                right = GetRight(rightStack);
            }
        }

        return false;
    }

    /// <summary>
    /// 669. Trim a Binary Search Tree
    /// </summary>
    public TreeNode TrimBST(TreeNode root, int L, int R)
    {
        if (root == null)
        {
            return null;
        }

        if (root.val > R)
        {
            return TrimBST(root.left, L, R);
        }

        if (root.val < L)
        {
            return TrimBST(root.right, L, R);
        }

        root.left = TrimBST(root.left, L, R);
        root.right = TrimBST(root.right, L, R);
        return root;
    }

    /// <summary>
    /// 679. 24 Game
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool JudgePoint24(int[] nums)
    {
        List<double> A = nums.Select(item => System.Convert.ToDouble(item)).ToList();
        return Solve(A);

        bool Solve(List<double> data)
        {
            switch (data.Count)
            {
                case 0:
                    return false;
                case 1:
                    return Math.Abs(data[0] - 24) < 1e-6;
            }

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    List<double> nums2 = data.Where((_, k) => k != i && k != j).ToList();
                    for (int k = 0; k < 4; k++)
                    {
                        switch (k)
                        {
                            case < 2 when j > i:
                                continue;
                            case 0:
                                nums2.Add(data[i] + data[j]);
                                break;
                            case 1:
                                nums2.Add(data[i] * data[j]);
                                break;
                            case 2:
                                nums2.Add(data[i] - data[j]);
                                break;
                            case 3 when data[j] != 0:
                                nums2.Add(data[i] / data[j]);
                                break;
                            case 3:
                                continue;
                        }

                        if (Solve(nums2))
                        {
                            return true;
                        }

                        nums2.Remove(nums2.Count - 1);
                    }
                }
            }

            return false;
        }
    }

    /// <summary>
    /// 682.棒球比赛
    /// </summary>
    /// <param name="ops"></param>
    /// <returns></returns>
    public int CalPoints(string[] ops)
    {
        int ret = 0;
        List<int> points = new List<int>();
        foreach (string op in ops)
        {
            int n = points.Count;
            switch (op[0])
            {
                case '+':
                    ret += points[n - 1] + points[n - 2];
                    points.Add(points[n - 1] + points[n - 2]);
                    break;
                case 'D':
                    ret += 2 * points[n - 1];
                    points.Add(2 * points[n - 1]);
                    break;
                case 'C':
                    ret -= points[n - 1];
                    points.RemoveAt(n - 1);
                    break;
                default:
                    ret += int.Parse(op);
                    points.Add(int.Parse(op));
                    break;
            }
        }

        return ret;
    }

    /// <summary>
    /// 695. Max Area of Island
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MaxAreaOfIsland(int[][] grid)
    {
        int ans = 0;
        int rowLength = grid.Length;
        int colLength = grid[0].Length;
        int[] di = new int[] { 0, 0, 1, -1 };
        int[] dj = new int[] { 1, -1, 0, 0 };
        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                int curr = 0;
                Queue<int> queueRow = new Queue<int>();
                Queue<int> queueCol = new Queue<int>();
                queueRow.Enqueue(row);
                queueCol.Enqueue(col);
                while (queueRow.Count != 0)
                {
                    int currRow = queueRow.Dequeue(), currCol = queueCol.Dequeue();
                    if (currRow < 0 || currCol < 0 || currRow == rowLength || currCol == colLength ||
                        grid[currRow][currCol] != 1)
                    {
                        continue;
                    }

                    ++curr;
                    grid[currRow][currCol] = 0;
                    for (int index = 0; index != 4; ++index)
                    {
                        int nextRow = currRow + di[index], nextCol = currCol + dj[index];
                        queueRow.Enqueue(nextRow);
                        queueCol.Enqueue(nextCol);
                    }
                }

                ans = Math.Max(ans, curr);
            }
        }

        return ans;
    }

    /// <summary>
    /// 700. Search in a Binary Search Tree
    /// </summary>
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null && root.val != val)
        {
            root = val < root.val ? root.left : root.right;
        }

        return root;
    }

    /// <summary>
    /// 701. Insert into a Binary Search Tree
    /// </summary>
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        // recursive
        // if(root == null)
        //     return new TreeNode(val);
        // if(val > root.val)
        //     root.right = InsertIntoBST(root.right, val);
        // else
        //     root.left = InsertIntoBST(root.left, val);
        // return root;
        // iterative
        if (root == null)
        {
            return new TreeNode(val);
        }

        TreeNode currentNode = root;
        while (true)
        {
            if (currentNode.val >= val)
            {
                if (currentNode.left != null)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode.left = new TreeNode(val);
                    break;
                }
            }
            else
            {
                if (currentNode.right != null)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    currentNode.right = new TreeNode(val);
                    break;
                }
            }
        }

        return root;
    }

    /// <summary>
    /// 704. Binary Search
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int BinarySearch(int[] nums, int target)
    {
        // version 1
        //int left = 0;
        //int right = nums.Length - 1;
        //while (left <= right)
        //{
        //    int mid = left + (right - left) / 2;
        //    if (nums[mid] > target)
        //    {
        //        right = mid - 1;
        //    }
        //    else if (nums[mid] < target)
        //    {
        //        left = mid + 1;
        //    }
        //    else
        //    {
        //        return mid;
        //    }
        //}
        //return -1;

        int left = 0;
        int right = nums.Length;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] > target)
            {
                right = mid;
            }
            else if (nums[mid] < target)
            {
                left = mid;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }

    /// <summary>
    /// 709. To Lower Case
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string ToLowerCase(string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char r in str.Select(c => (char)(c | 32)))
        {
            sb.Append(r);
        }

        return sb.ToString();

        // LINQ
        // return string.Concat(str.Select(c => c >= 'A' && c <= 'Z' ? (char)(c + 32) : c));
    }

    /// <summary>
    /// 720. Longest Word in Dictionary
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public string LongestWord(string[] words)
    {
        Trie trie = new Trie();
        foreach (string word in words)
        {
            trie.Insert(word);
        }

        string longest = string.Empty;
        foreach (string word in words)
        {
            if (trie.Search(word))
            {
                if (word.Length > longest.Length || (word.Length == longest.Length && word.CompareTo(longest) < 0))
                {
                    longest = word;
                }
            }
        }

        return longest;
    }

    /// <summary>
    /// 724. Find Pivot Index
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int PivotIndex(int[] nums)
    {
        int total = nums.Sum();
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (2 * sum + nums[i] == total)
            {
                return i;
            }
            sum += nums[i];
        }
        return -1;
    }

    /// <summary>
    /// 728. Self Dividing Numbers
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        bool IsSelfDividing(int num)
        {
            int tmp = num;
            while (tmp > 0)
            {
                int digit = tmp % 10;
                if (digit == 0 || num % digit != 0)
                {
                    return false;
                }

                tmp /= 10;
            }

            return true;
        }

        IList<int> ans = new List<int>();
        for (int i = left; i <= right; i++)
        {
            if (IsSelfDividing(i))
            {
                ans.Add(i);
            }
        }

        return ans;
    }

    /// <summary>
    /// 733. Flood Fill
    /// </summary>
    /// <param name="image"></param>
    /// <param name="sr"></param>
    /// <param name="sc"></param>
    /// <param name="newColor"></param>
    /// <returns></returns>
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        int[] dx = { 1, 0, 0, -1 };
        int[] dy = { 0, 1, -1, 0 };
        int currentColor = image[sr][sc];
        if (currentColor == newColor)
        {
            return image;
        }

        int n = image.Length, m = image[0].Length;
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new[] { sr, sc });
        image[sr][sc] = newColor;
        while (queue.Any())
        {
            int[] pair = queue.Dequeue();
            int x = pair[0], y = pair[1];
            for (int i = 0; i < 4; i++)
            {
                int mx = x + dx[i], my = y + dy[i];
                if (mx < 0 || mx >= n || my < 0 || my >= m || image[mx][my] != currentColor)
                {
                    continue;
                }

                queue.Enqueue(new[] { mx, my });
                image[mx][my] = newColor;
            }
        }

        return image;
    }

    /// <summary>
    /// 739. Daily Temperatures
    /// </summary>
    public int[] DailyTemperatures(int[] T)
    {
        Stack<int> stack = new Stack<int>();
        int len = T.Length;
        int[] ans = new int[len];
        for (int i = 0; i < len; i++)
        {
            while (stack.Count != 0 && T[i] > T[stack.Peek()])
            {
                int t = stack.Peek();
                stack.Pop();
                ans[t] = i - t;
            }

            stack.Push(i);
        }

        return ans;
    }

    /// <summary>
    /// 784. Letter Case Permutation
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public List<string> LetterCasePermutation(string s)
    {
        List<StringBuilder> ans = new List<StringBuilder> { new StringBuilder() };
        foreach (char c in s)
        {
            int n = ans.Count;
            if (char.IsLetter(c))
            {
                for (int i = 0; i < n; ++i)
                {
                    ans.Add(new StringBuilder(ans[i].ToString()));
                    ans[i].Append(char.ToLower(c));
                    ans[n + i].Append(char.ToUpper(c));
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    ans[i].Append(c);
                }
            }
        }

        return ans.Select(sb => sb.ToString()).ToList();
    }

    /// <summary>
    /// 796. Rotate String
    /// </summary>
    /// <param name="A"></param>
    /// <param name="B"></param>
    /// <returns></returns>
    public bool RotateString(string A, string B)
    {
        return A.Length == B.Length && (A + A).Contains(B);
    }

    /// <summary>
    /// 804. Unique Morse Code Words
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public int UniqueMorseRepresentations(string[] words)
    {
        string[] morse = new string[] {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };
        HashSet<string> seen = new HashSet<string>();
        foreach (string word in words)
        {
            StringBuilder code = new StringBuilder();
            foreach (char c in word)
            {
                code.Append(morse[c - 'a']);
            }

            seen.Add(code.ToString());
        }

        return seen.Count;
    }

    /// <summary>
    /// 806. Number of Lines To Write String
    /// </summary>
    /// <param name="widths"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public int[] NumberOfLines(int[] widths, string s)
    {
        const int maxWidth = 100;
        int lines = 1, width = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int need = widths[s[i] - 'a'];
            width += need;
            if (width > maxWidth)
            {
                lines++;
                width = need;
            }
        }

        return new int[] { lines, width };
    }

    /// <summary>
    /// 807. Max Increase to Keep City Skyline
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MaxIncreaseKeepingSkyline(int[][] grid)
    {
        int n = grid.Length;
        int[] rowMax = new int[n];
        int[] colMax = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rowMax[i] = Math.Max(rowMax[i], grid[i][j]);
                colMax[j] = Math.Max(colMax[j], grid[i][j]);
            }
        }

        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                ans += Math.Min(rowMax[i], colMax[j]) - grid[i][j];
            }
        }

        return ans;
    }

    /// <summary>
    /// 819. Most Common Word
    /// </summary>
    /// <param name="paragraph"></param>
    /// <param name="banned"></param>
    /// <returns></returns>
    public string MostCommonWord(string paragraph, string[] banned)
    {
        HashSet<string> bannedSet = new HashSet<string>();
        foreach (string word in banned)
        {
            bannedSet.Add(word);
        }

        int maxFrequency = 0;
        Dictionary<string, int> frequencies = new Dictionary<string, int>();
        StringBuilder sb = new StringBuilder();
        int len = paragraph.Length;
        for (int i = 0; i <= len; i++)
        {
            if (i < len && char.IsLetter(paragraph[i]))
            {
                sb.Append(char.ToLower(paragraph[i]));
            }
            else if (sb.Length > 0)
            {
                string word = sb.ToString();
                if (!bannedSet.Contains(word))
                {
                    if (!frequencies.ContainsKey(word))
                    {
                        frequencies.Add(word, 1);
                    }
                    else
                    {
                        frequencies[word]++;
                    }

                    maxFrequency = Math.Max(maxFrequency, frequencies[word]);
                }

                sb.Clear();
            }
        }

        string mostCommon = "";
        foreach ((string word, int frequency) in frequencies)
        {
            if (frequency == maxFrequency)
            {
                mostCommon = word;
                break;
            }
        }

        return mostCommon;
    }

    /// <summary>
    /// 821. Shortest Distance to a Character
    /// </summary>
    /// <param name="s"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public int[] ShortestToChar(string s, char c)
    {
        int n = s.Length;
        int[] ans = new int[n];
        int prev = int.MinValue / 2;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == c)
            {
                prev = i;
            }

            ans[i] = i - prev;
        }

        prev = int.MaxValue / 2;
        for (int i = n - 1; i >= 0; i--)
        {
            if (s[i] == c)
            {
                prev = i;
            }

            ans[i] = Math.Min(ans[i], prev - i);
        }

        return ans;
    }

    /// <summary>
    /// 824. 山羊拉丁文
    /// </summary>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public string ToGoatLatin(string sentence)
    {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        if (sentence.Length == 0)
        {
            return string.Empty;
        }

        StringBuilder sb = new StringBuilder("a");
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (vowels.Contains(words[i][0]))
            {
                words[i] = words[i] + "ma" + sb.ToString();
            }
            else
            {
                words[i] = words[i][1..^0] + words[i][0] + "ma" + sb.ToString();
            }

            sb.Append('a');
        }

        return string.Join(" ", words);
    }

    /// <summary>
    /// 838.推多米诺
    /// </summary>
    /// <param name="dominoes"></param>
    /// <returns></returns>
    public string PushDominoes(string dominoes)
    {
        char[] s = dominoes.ToCharArray();
        int n = s.Length, i = 0;
        char left = 'L';
        while (i < n)
        {
            int j = i;
            while (j < n && s[j] == '.')
            {
                j++;
            }

            char right = j < n ? s[j] : 'R';
            if (left == right)
            {
                while (i < j)
                {
                    s[i++] = right;
                }
            }
            else if (left == 'R' && right == 'L')
            {
                int k = j - 1;
                while (i < k)
                {
                    s[i++] = 'R';
                    s[k--] = 'L';
                }
            }

            left = right;
            i = j + 1;
        }

        return new string(s);
    }

    /// <summary>
    /// 844. Backspace String Compare 
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool BackspaceCompare(string s, string t)
    {
        int i = s.Length - 1, j = t.Length - 1;
        int skipS = 0, skipT = 0;
        while (i >= 0 || j >= 0)
        {
            while (i >= 0)
            {
                if (s[i] == '#')
                {
                    skipS++;
                    i--;
                }
                else if (skipS > 0)
                {
                    skipS--;
                    i--;
                }
                else
                {
                    break;
                }
            }

            while (j >= 0)
            {
                if (t[j] == '#')
                {
                    skipT++;
                    j--;
                }
                else if (skipT > 0)
                {
                    skipT--;
                    j--;
                }
                else
                {
                    break;
                }
            }

            if (i >= 0 && j >= 0)
            {
                if (s[i] != t[j])
                {
                    return false;
                }
            }
            else
            {
                if (i >= 0 || j >= 0)
                {
                    return false;
                }
            }

            i--;
            j--;
        }

        return true;
    }

    /// <summary>
    /// 846. 一手顺子
    /// </summary>
    /// <param name="hand"></param>
    /// <param name="groupSize"></param>
    /// <returns></returns>
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        int n = hand.Length;
        if (n % groupSize != 0)
        {
            return false;
        }

        Array.Sort(hand);
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int x in hand)
        {
            if (!count.ContainsKey(x))
            {
                count.Add(x, 0);
            }

            count[x]++;
        }

        foreach (int x in hand)
        {
            if (!count.ContainsKey(x))
            {
                continue;
            }

            for (int j = 0; j < groupSize; j++)
            {
                int num = x + j;
                if (!count.ContainsKey(num))
                {
                    return false;
                }

                count[num]--;
                if (count[num] == 0)
                {
                    count.Remove(num);
                }
            }
        }

        return true;
    }

    /// <summary>
    /// 852. Peak Index in a Mountain Array
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int PeakIndexInMountainArray(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int mid = (l + r) / 2;
            if (nums[mid] < nums[mid + 1])
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return l;
    }

    /// <summary>
    /// 876. Middle of the Linked List
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    /// <summary>
    /// 883. Projection Area of 3D Shapes 
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int ProjectionArea(int[][] grid)
    {
        int ans = 0;
        for (int x = 0; x < grid.Length; x++)
        {
            int row = 0;
            int column = 0;
            for (int y = 0; y < grid[x].Length; y++)
            {
                if (grid[x][y] != 0)
                {
                    ans++;
                }

                row = Math.Max(row, grid[x][y]);
                column = Math.Max(column, grid[y][x]);
            }

            ans += row + column;
        }

        return ans;
    }

    /// <summary>
    /// 884. Uncommon Words from Two Sentences.
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public string[] UncommonFromSentences(string s1, string s2)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        foreach (string word in s1.Split(' '))
        {
            if (dic.ContainsKey(word))
            {
                dic[word]++;
            }
            else
            {
                dic[word] = 1;
            }
        }

        foreach (string word in s2.Split(' '))
        {
            if (dic.ContainsKey(word))
            {
                dic[word]++;
            }
            else
            {
                dic[word] = 1;
            }
        }

        return (from word in dic where word.Value == 1 select word.Key).ToArray();
    }

    /// <summary>
    /// 892. Surface Area of 3D Shapes
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int SurfaceArea(int[][] grid)
    {
        int res = 0, n = grid.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] > 0)
                {
                    res += grid[i][j] * 4 + 2;
                }

                if (i > 0)
                {
                    res -= Math.Min(grid[i][j], grid[i - 1][j]) * 2;
                }

                if (j > 0)
                {
                    res -= Math.Min(grid[i][j], grid[i][j - 1]) * 2;
                }
            }
        }

        return res;
    }

    /// <summary>
    /// 893. Groups of Special-Equivalent Strings
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public int NumSpecialEquivGroups(string[] A)
    {
        HashSet<string> seen = new HashSet<string>();
        foreach (string s in A)
        {
            int[] count = new int[52];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a' + 26 * (i % 2)]++;
            }

            seen.Add(string.Join(",", count));
        }

        return seen.Count;
    }

    /// <summary>
    /// 896. Monotonic Array
    /// </summary>
    /// <param name="nums"></param>
    /// <returns><c>true</c> if and only if the given array A is monotonic; otherwise, <c>false</c></returns>
    public bool IsMonotonic(int[] nums)
    {
        int store = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int c = nums[i].CompareTo(nums[i + 1]);
            if (c == 0)
            {
                continue;
            }

            if (c != store && store != 0)
            {
                return false;
            }

            store = c;
        }

        return true;
    }

    /// <summary>
    /// 905. Sort Array By Parity
    /// </summary>
    public int[] SortArrayByParity(int[] nums)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            while (left < right && nums[left] % 2 == 0)
            {
                left++;
            }
            while (left < right && nums[right] % 2 == 1)
            {
                right--;
            }
            if (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
                right--;
            }
        }
        return nums;
    }

    /// <summary>
    /// 908. Smallest Range I
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int SmallestRangeI(int[] nums, int k)
    {
        int min = nums.Min();
        int max = nums.Max();
        return max - min <= 2 * k ? 0 : max - min - 2 * k;
    }

    /// <summary>
    /// 917.仅仅反转字母
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ReverseOnlyLetters(string s)
    {
        char[] letters = s.ToCharArray();
        int l = 0, r = s.Length - 1;
        while (true)
        {
            while (l < r && !char.IsLetter(s[l]))
            {
                l++;
            }

            while (r > l && !char.IsLetter(s[r]))
            {
                r--;
            }

            if (l >= r)
            {
                break;
            }

            //char tmp = letters[l];
            //letters[l] = letters[r];
            //letters[r] = tmp;
            Utilities.Swap(letters, l, r);
            l++;
            r--;
        }

        return new string(letters);
    }

    /// <summary>
    /// 938. Range Sum of BST
    /// </summary>
    /// <param name="root"></param>
    /// <param name="L"></param>
    /// <param name="R"></param>
    /// <returns></returns>
    public int RangeSumBST(TreeNode root, int L, int R)
    {
        // Recursive
        //int sum = 0;
        //if (root == null) return sum;
        //if (root.val > L)
        //    sum += RangeSumBST(root.left, L, R);
        //if (root.val < R)
        //    sum += RangeSumBST(root.right, L, R);
        //if (root.val >= L && root.val <= R)
        //    sum += root.val;
        //return sum;

        // Iterative
        int sum = 0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            TreeNode currentNode = stack.Pop();
            if (currentNode == null)
            {
                continue;
            }

            if (L <= currentNode.val && currentNode.val <= R)
            {
                sum += currentNode.val;
            }

            if (L < currentNode.val)
            {
                stack.Push(currentNode.left);
            }

            if (currentNode.val < R)
            {
                stack.Push(currentNode.right);
            }
        }

        return sum;
    }

    /// <summary>
    /// 942. DI String Match
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int[] DIStringMatch(string s)
    {
        int n = s.Length, lo = 0, hi = n;
        int[] perm = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            perm[i] = s[i] == 'I' ? lo++ : hi--;
        }
        perm[n] = lo;
        return perm;
    }

    /// <summary>
    /// 944. Delete Columns to Make Sorted
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public int MinDeletionSize(string[] strs)
    {
        int row = strs.Length;
        int col = strs[0].Length;
        int ans = 0;
        for (int j = 0; j < col; j++)
        {
            for (int i = 1; i < row; i++)
            {
                if (strs[i - 1][j] > strs[i][j])
                {
                    ans++;
                    break;
                }
            }
        }
        return ans;
    }

    /// <summary>
    /// 953. Verifying an Alien Dictionary
    /// </summary>
    /// <param name="words"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    public bool IsAlienSorted(string[] words, string order)
    {
        int[] index = new int[26];
        for (int i = 0; i < order.Length; ++i)
        {
            index[order[i] - 'a'] = i;
        }
        for (int i = 1; i < words.Length; ++i)
        {
            bool valid = false;
            for (int j = 0; j < words[i - 1].Length && j < words[i].Length; ++j)
            {
                int prev = index[words[i - 1][j] - 'a'];
                int curr = index[words[i][j] - 'a'];
                if (prev < curr)
                {
                    valid = true;
                    break;
                }
                else if (prev > curr)
                {
                    return false;
                }
            }
            if (!valid)
            {
                if (words[i - 1].Length > words[i].Length)
                {
                    return false;
                }
            }
        }
        return true;
    }

    /// <summary>
    /// 961. N-Repeated Element in Size 2N Array
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RepeatedNTimes(int[] nums)
    {
        ISet<int> found = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!found.Add(num))
            {
                return num;
            }
        }
        return -1;
    }

    /// <summary>
    /// 976. Largest Perimeter Triangle
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        for (int i = nums.Length - 1; i >= 2; --i)
        {
            if (nums[i - 2] + nums[i - 1] > nums[i])
            {
                return nums[i - 2] + nums[i - 1] + nums[i];
            }
        }
        return 0;
    }

    /// <summary>
    /// 977. Squares of a Sorted Array
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortedSquares(int[] nums)
    {
        int len = nums.Length;
        int[] ans = new int[len];
        for (int i = 0, j = len - 1, pos = len - 1; i <= j;)
        {
            if (nums[i] * nums[i] > nums[j] * nums[j])
            {
                ans[pos] = nums[i] * nums[i];
                ++i;
            }
            else
            {
                ans[pos] = nums[j] * nums[j];
                --j;
            }

            --pos;
        }

        return ans;
    }

    /// <summary>
    /// 994. Rotting Oranges
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int OrangeRotting(int[][] grid)
    {
        int[] dr = new int[] { -1, 0, 1, 0 };
        int[] dc = new int[] { 0, -1, 0, 1 };
        int rowLength = grid.Length, colLength = grid[0].Length;
        Queue<int> queue = new Queue<int>();
        Dictionary<int, int> depth = new Dictionary<int, int>();
        for (int row = 0; row < rowLength; ++row)
        {
            for (int col = 0; col < colLength; ++col)
            {
                if (grid[row][col] != 2)
                {
                    continue;
                }

                int code = row * colLength + col;
                queue.Enqueue(code);
                depth.Add(code, 0);
            }
        }

        int ans = 0;
        while (queue.Count != 0)
        {
            int code = queue.Dequeue();
            int row = code / colLength, col = code % colLength;
            for (int k = 0; k < 4; k++)
            {
                int nr = row + dr[k];
                int nc = col + dc[k];
                if (0 > nr || nr >= rowLength || 0 > nc || nc >= colLength || grid[nr][nc] != 1)
                {
                    continue;
                }

                grid[nr][nc] = 2;
                int nCode = nr * colLength + nc;
                queue.Enqueue(nCode);
                depth.Add(nCode, depth[code] + 1);
                ans = depth[nCode];
            }
        }

        if (grid.SelectMany(row => row).Any(v => v == 1))
        {
            return -1;
        }

        return ans;
    }

    /// <summary>
    /// 1022. Sum of Root To Leaf Binary Numbers
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int SumRootToLeaf(TreeNode root)
    {
        int DFS(TreeNode node, int val)
        {
            if(node is null)
            {
                return 0;
            }
            val = (val << 1) | node.val;
            if(node.left is null && node.right is null)
            {
                return val;
            }
            return DFS(node.left, val) + DFS(node.right, val);
        }
        return DFS(root, 0);
    }

    /// <summary>
    /// 1025. Divisor Game
    /// </summary>
    /// <param name="N"></param>
    /// <returns></returns>
    public bool DivisorGame(int N)
    {
        return N % 2 == 0;
    }

    /// <summary>
    /// 1046. Last Stone Weight
    /// </summary>
    /// <param name="stones"></param>
    /// <returns></returns>
    public int LastStoneWeight(List<int> stones)
    {
        PriorityQueue<int> pq = new PriorityQueue<int>();
        foreach (int stone in stones)
        {
            pq.Push(stone);
        }

        while (pq.Count > 1)
        {
            int s1 = pq.Top();
            pq.Pop();
            int s2 = pq.Top();
            pq.Pop();
            if (s1 > s2)
            {
                pq.Push(s1 - s2);
            }
        }

        return pq.IsEmpty() ? 0 : pq.Top();
    }

    /// <summary>
    /// 1249
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string MinRemoveToMakeValid(string s)
    {
        StringBuilder sb = new StringBuilder();
        int openSeen = 0;
        int balance = 0;
        foreach (char c in s)
        {
            switch (c)
            {
                case '(':
                    openSeen++;
                    balance++;
                    break;
                case ')' when balance == 0:
                    continue;
                case ')':
                    balance--;
                    break;
            }

            sb.Append(c);
        }

        StringBuilder res = new StringBuilder();
        int openToKeep = openSeen - balance;
        for (int i = 0; i < sb.Length; i++)
        {
            char c = sb[i];
            if (c == '(')
            {
                openToKeep--;
                if (openToKeep < 0)
                {
                    continue;
                }
            }

            res.Append(c);
        }

        return res.ToString();
    }

    /// <summary>
    /// 1260. Shift 2D Grid
    /// </summary>
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        int n = grid.Length, m = grid[0].Length;
        // use array 
        IList<IList<int>> res = new int[n][];
        for (int r = 0; r < n; r++)
        {
            res[r] = new int[m];
        }

        // use list
        // IList<IList<int>> res = new IList<List<int>>();
        // for (int i = 0; i < n; i++)
        // {
        //     List<int> tmp = new List<int>();
        //     for (int j = 0; j < m; j++)    
        //         tmp.Add(0);
        //     res.Add(tmp);
        // }

        k %= m * n;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int index = (i * m + j + k) % (m * n);
                int x = index / m, y = index % m;
                res[x][y] = grid[i][j];
            }
        }

        return res;
    }

    /// <summary>
    /// 1305. All Elements in Two Binary Search Trees
    /// </summary>
    /// <param name="root1"></param>
    /// <param name="root2"></param>
    /// <returns></returns>
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
    {
        void Inorder(TreeNode node, IList<int> res)
        {
            if (node != null)
            {
                Inorder(node.left, res);
                res.Add((node.val));
                Inorder(node.right, res);
            }
        }

        IList<int> nums1 = new List<int>();
        IList<int> nums2 = new List<int>();
        Inorder(root1, nums1);
        Inorder(root2, nums2);
        IList<int> merged = new List<int>();
        int p1 = 0, p2 = 0;
        while (true)
        {
            if (p1 == nums1.Count)
            {
                while (p2 < nums2.Count)
                {
                    merged.Add(nums2[p2++]);
                }

                break;
            }

            if (p2 == nums1.Count)
            {
                while (p1 < nums1.Count)
                {
                    merged.Add(nums1[p1++]);
                }

                break;
            }

            merged.Add(nums1[p1] < nums2[p2] ? nums1[p1++] : nums2[p2++]);
        }

        return merged;
    }

    /// <summary>
    /// 1380.矩阵中的幸运数
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        int[] minRow = new int[m];
        Array.Fill(minRow, int.MaxValue);
        int[] maxCol = new int[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                minRow[i] = Math.Min(minRow[i], matrix[i][j]);
                maxCol[j] = Math.Max(maxCol[j], matrix[i][j]);
            }
        }

        IList<int> res = new List<int>();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == minRow[i] && matrix[i][j] == maxCol[j])
                {
                    res.Add(matrix[i][j]);
                }
            }
        }

        return res;
    }

    /// <summary>
    /// 1447.最简分数
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<string> SimplifiedFractions(int n)
    {
        IList<string> res = new List<string>();
        for (int denominator = 2; denominator <= n; ++denominator)
        {
            for (int numerator = 1; numerator < denominator; ++numerator)
            {
                if (Gcd(numerator, denominator) == 1)
                {
                    res.Add(numerator + "/" + denominator);
                }
            }
        }

        return res;

        int Gcd(int a, int b)
        {
            return b != 0 ? Gcd(b, a % b) : a;
        }
    }

    /// <summary>
    /// 1486. XOR Operation in an Array.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="start"></param>
    /// <returns></returns>
    public int XorOperation(int n, int start)
    {
        // (sumXor(s - 1) ^ sumXor(s + n - 1)) * 2 + e; s = start/2, e = (0 || 1)
        int s = start >> 1;
        int e = n & start & 1;
        int res = SumXor(s - 1) ^ SumXor(s + n - 1);
        return res << 1 | e;

        int SumXor(int num)
        {
            return (num % 4) switch {
                0 => num,
                1 => 1,
                2 => num + 1,
                _ => 0
            };
        }
    }

    /// <summary>
    /// 1491. Average Salary Excluding the Minimum and Maximum Salary
    /// </summary>
    /// <param name="salary"></param>
    /// <returns></returns>
    public double Average(int[] salary)
    {
        int min = int.MaxValue, max = int.MinValue;
        int sum = 0;
        foreach (int item in salary)
        {
            sum += item;
            max = Math.Max(max, item);
            min = Math.Min(min, item);
        }
        return (sum - max - min) / (salary.Length - 2);
    }

    /// <summary>
    /// 1523. Count Odd Numbers in an Interval Range
    /// </summary>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public int CountOdds(int low, int high)
    {
        int PreSum(int num)
        {
            return (num + 1) >> 1;
        }
        return PreSum(high) - PreSum(low - 1);
    }

    /// <summary>
    /// 1672. 最富有客户的资产总量
    /// </summary>
    /// <param name="accounts"></param>
    /// <returns></returns>
    public int MaximumWealth(int[][] accounts)
    {
        return accounts.Max(x => x.Sum());
    }

    /// <summary>
    /// 1779. Find Nearest Point That Has the Same X or Y Coordinate
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="points"></param>
    /// <returns></returns>
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        int minDistance = int.MaxValue;
        int ans = -1;
        for (int i = 0; i < points.Length; i++)
        {
            if (points[i][0] == x || points[i][1] == y)
            {
                int distance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    ans = i;
                }
            }
        }
        return ans;
    }

    /// <summary>
    /// 1791. 找出星型图的中心节点
    /// </summary>
    /// <param name="edges"></param>
    /// <returns></returns>
    public int FindCenter(int[][] edges)
    {
        return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1] ? edges[0][0] : edges[0][1];
    }

    /// <summary>
    /// 1823. Find the Winner of the Circular Game
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int FindTheWinner(int n, int k)
    {
        int winner = 1;
        for (int i = 2; i <= n; i++)
        {
            winner = (k + winner - 1) % i + 1;
        }
        return winner;
    }

    /// <summary>
    /// 1984.学生分数的最小差值
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinimumDifference(int[] nums, int k)
    {
        int n = nums.Length;
        Array.Sort(nums);
        int res = int.MaxValue;
        for (int i = 0; i + k - 1 < n; ++i)
        {
            res = Math.Min(res, nums[i + k - 1] - nums[i]);
        }

        return res;
    }

    /// <summary>
    /// 1991.找到数组中间位置
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMiddleIndex(int[] nums)
    {
        int total = nums.Sum();
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if ((2 * sum + nums[i]) == total)
            {
                return i;
            }

            sum += nums[i];
        }

        return -1;
    }

    /// <summary>
    /// 1995. 统计特殊四元组 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountQuadruplets(int[] nums)
    {
        int n = nums.Length;
        int ans = 0;
        Dictionary<int, int> cnt = new Dictionary<int, int>();
        for (int b = n - 3; b >= 1; --b)
        {
            for (int d = b + 2; d < n; ++d)
            {
                int difference = nums[d] - nums[b + 1];
                if (!cnt.ContainsKey(difference))
                {
                    cnt.Add(difference, 1);
                }
                else
                {
                    ++cnt[difference];
                }
            }

            for (int a = 0; a < b; ++a)
            {
                int sum = nums[a] + nums[b];
                if (cnt.ContainsKey(sum))
                {
                    ans += cnt[sum];
                }
            }
        }

        return ans;
    }

    /// <summary>
    /// 2006.差的绝对值为k的数对数目
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int CountKDifference(int[] nums, int k)
    {
        int ans = 0, n = nums.Length;
        Dictionary<int, int> cnt = new Dictionary<int, int>();
        for (int j = 0; j < n; j++)
        {
            ans += (cnt.ContainsKey(nums[j] - k) ? cnt[nums[j] - k] : 0)
                   + (cnt.ContainsKey(nums[j] + k) ? cnt[nums[j] + k] : 0);
            if (!cnt.ContainsKey(nums[j]))
            {
                cnt.Add(nums[j], 0);
            }

            ++cnt[nums[j]];
        }

        return ans;
    }

    /// <summary>
    /// 2016.增量元素之间的最大差值
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaximumDifference(int[] nums)
    {
        int n = nums.Length;
        int ans = -1, preMin = nums[0];
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > preMin)
            {
                ans = Math.Max(ans, nums[i] - preMin);
            }
            else
            {
                preMin = nums[i];
            }
        }

        return ans;
    }

    /// <summary>
    /// 2044. 统计按位或能得到最大值的子集数目
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountMaxOrSubsets(int[] nums)
    {
        int maxOr = 0, cnt = 0;
        Dfs(0, 0);
        return cnt;

        void Dfs(int pos, int orVal)
        {
            if (pos == nums.Length)
            {
                if (orVal > maxOr)
                {
                    maxOr = orVal;
                    cnt = 1;
                }
                else if (orVal == maxOr)
                {
                    cnt++;
                }

                return;
            }

            Dfs(pos + 1, orVal | nums[pos]);
            Dfs(pos + 1, orVal);
        }
    }

    /// <summary>
    /// 2055.蜡烛之间的盘子
    /// </summary>
    /// <param name="s"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public int[] PlatesBetweenCandles(string s, int[][] queries)
    {
        int n = s.Length;
        int[] preSum = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == '*')
            {
                sum++;
            }

            preSum[i] = sum;
        }

        int[] left = new int[n];
        for (int i = 0, l = -1; i < n; i++)
        {
            if (s[i] == '|')
            {
                l = i;
            }

            left[i] = l;
        }

        int[] right = new int[n];
        for (int i = n - 1, r = -1; i >= 0; i--)
        {
            if (s[i] == '|')
            {
                r = i;
            }

            right[i] = r;
        }

        int[] ans = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            int[] query = queries[i];
            int x = right[query[0]], y = left[query[1]];
            ans[i] = x == -1 || y == -1 || x >= y ? 0 : preSum[y] - preSum[x];
        }

        return ans;
    }

    /// <summary>
    /// 6078. Rearrange Characters to Make Target String
    /// </summary>
    /// <param name="s"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int RearrageCharacters(string s, string target)
    {
        Dictionary<char, int> sDic = new Dictionary<char, int>();
        Dictionary<char, int> targetDic = new Dictionary<char, int>();
        foreach (char ch in s)
        {
            if (sDic.ContainsKey(ch))
            {
                sDic[ch]++;
            }
            else
            {
                sDic.Add(ch, 1);
            }
        }
        foreach (char ch in target)
        {
            if (targetDic.ContainsKey(ch))
            {
                targetDic[ch]++;
            }
            else
            {
                targetDic.Add(ch, 1);
            }
        }
        int ans = int.MaxValue;
        foreach (char ch in target)
        {
            int sValue = 0;
            sDic.TryGetValue(ch, out sValue);
            ans = Math.Min(ans, sValue / targetDic[ch]);
        }
        return ans;
    }

}