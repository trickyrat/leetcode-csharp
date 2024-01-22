// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FindTargetUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateTreeNode([5, 3, 6, 2, 4, null, 7]),
            9,
            true
        ];
        yield return
        [
            Util.CreateTreeNode([5, 3, 6, 2, 4, null, 7]),
            28,
            false
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(TreeNode root, int target, bool expected)
    {

        var actual = Solution.FindTarget(root, target);
        Assert.Equal(expected, actual);
    }
}
