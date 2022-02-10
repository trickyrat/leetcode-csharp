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
            TreeNode actual = Solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
            TreeNode expected = new TreeNode(0) 
            {
                left = new TreeNode(-3) 
                {
                    left = new TreeNode(-10),
                    right = null
                },
                right = new TreeNode(9) 
                {
                    left = new TreeNode(5),
                    right = null
                }
            };
            Assert.Equal(expected, actual);
        }
    }
}
