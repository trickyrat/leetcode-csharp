// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCode.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FindTargetUnitTest
{
    private readonly Solution _solution;
    public FindTargetUnitTest()
    {
        _solution = new Solution();
    }
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateTreeNode(new List<int?>{ 5, 3, 6, 2, 4, null, 7 }),
            9,
            true
        };
        yield return new object[]
        {
            Utilities.CreateTreeNode(new List<int?>{ 5, 3, 6, 2, 4, null, 7 }),
            28,
            false
        };
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(TreeNode root, int target, bool expected)
    {

        var actual = _solution.FindTarget(root, target);
        Assert.Equal(expected, actual);
    }
}
