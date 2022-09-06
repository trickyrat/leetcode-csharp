// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test;
public class FindDuplicateSubtreesUnitTest
{
    private readonly Solution _solution;

    public FindDuplicateSubtreesUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateTreeNodeIteratively(new List<int?>{ 1, 2, 3, 4, null, 2, 4, null, null, 4 }),
            new List<TreeNode>
            {
                Utilities.CreateTreeNodeIteratively(new List<int?>{ 4 }),
                Utilities.CreateTreeNodeIteratively(new List<int?>{ 2, 4 }),
            }
        };

        yield return new object[]
        {
            Utilities.CreateTreeNodeIteratively(new List<int?>{ 2, 1, 1 }),
            new List<TreeNode>
            {
                Utilities.CreateTreeNodeIteratively(new List<int?>{ 1 })
            }
        };

        yield return new object[]
        {
            Utilities.CreateTreeNodeIteratively(new List<int?>{ 2, 2, 2, 3, null, 3, null }),
            new List<TreeNode>
            {
                Utilities.CreateTreeNodeIteratively(new List<int?>{ 3 }),
                Utilities.CreateTreeNodeIteratively(new List<int?>{ 2, 3 }),
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, IList<TreeNode> expected)
    {
        var actual = _solution.FindDuplicateSubtrees(root);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }

}

