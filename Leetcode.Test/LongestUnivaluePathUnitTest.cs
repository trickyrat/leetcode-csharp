// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test;
public class LongestUnivaluePathUnitTest
{
    private readonly Solution _solution;

    public LongestUnivaluePathUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateTreeNodeIteratively(new List<int?>{ 5,4,5,1,1,null,5 }),
            2
        };
        yield return new object[]
        {
            Utilities.CreateTreeNodeIteratively(new List<int?>{ 1,4,5,4,4,null,5 }),
            2
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int expected)
    {
        var actual = _solution.LongestUnivaluePath(root);
        Assert.Equal(expected, actual);
    }
}

