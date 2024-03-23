// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SortedListToBSTUnitTest
{
    [Fact]
    public void Test()
    {
        var actualNode = Solution.SortedArrayToBst(new int[] { -10, -3, 0, 5, 9 });
        var expectedNode = Util.CreateTreeNode([0, -10, 5, null, -3, null, 9]);
        var actual = Util.PreorderTraversal(actualNode);
        var expected = Util.PreorderTraversal(expectedNode);
        Assert.Equal(expected, actual);
    }
}