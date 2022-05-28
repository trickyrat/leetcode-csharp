// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test;

public class GetAllElementsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateTreeNodeWithBFS(new List<int?> { 2, 1, 4 }),
            Utilities.CreateTreeNodeWithBFS(new List<int?> { 1, 0, 3 }),
            new List<int> { 0, 1, 1, 2, 3, 4 }
        };
        yield return new object[]
        {
            Utilities.CreateTreeNodeWithBFS(new List<int?> { 1, null, 8 }),
            Utilities.CreateTreeNodeWithBFS(new List<int?> { 8, 1 }),
            new List<int> { 1, 1, 8, 8 }
        };
    }

    private readonly Solution _solution;

    public GetAllElementsUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(TreeNode root1, TreeNode root2, IList<int> expected)
    {
        IList<int> actual = _solution.GetAllElements(root1, root2);
        Assert.Equal(expected, expected);
    }
}