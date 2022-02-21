// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leetcodecsharp.DataStructure;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class SortedListToBSTUnitTest
    {
        [Fact]
        public void Test()
        {
            TreeNode actualNode = Solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
            TreeNode expectedNode = new TreeNode(0) 
            {
                left = new TreeNode(-10) 
                {
                    left = null,
                    right = new TreeNode(-3)
                },
                right = new TreeNode(5) 
                {
                    left = null,
                    right = new TreeNode(9)
                }
            };
            List<int> actual = Utils.PreorderTraversal(actualNode);
            List<int> expected = Utils.PreorderTraversal(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
