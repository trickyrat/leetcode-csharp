// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class InsertIntoMaxTreeUnitTest
{
    private readonly Solution _solution;

    public InsertIntoMaxTreeUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Util.CreateTreeNode(new List<int?>{ 4,1,3,null,null,2 }),
            5,
            Util.CreateTreeNode(new List<int?>{ 5,4,null,1,3,null,null,2 })
        };
        yield return new object[]
        {
            Util.CreateTreeNode(new List<int?>{ 5,2,4,null,1 }),
            3,
            Util.CreateTreeNode(new List<int?>{ 5,2,4,null,1,null,3 })
        };
        yield return new object[]
        {
            Util.CreateTreeNode(new List<int?>{ 5,2,3,null,1 }),
            4,
            Util.CreateTreeNode(new List<int?>{ 5,2,4,null,1,3 })
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root, int val, TreeNode expected)
    {
        var actual = _solution.InsertIntoMaxTree(root, val);
        Assert.Equal(expected, actual, new TreeNodeComparer());
    }

}

