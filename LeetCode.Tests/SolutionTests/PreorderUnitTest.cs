// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using LeetCode.DataStructure;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class PreorderUnitTest
{
    public static TheoryData<Node, IList<int>> Data =>
        new()
        {
            { Util.CreateNTree([1, null, 3, 2, 4, null, 5, 6]), [1, 3, 5, 6, 2, 4] },
            {
                Util.CreateNTree([
                    1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13,
                    null, null, 14
                ]),
                [1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10]
            }
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(Node root, IList<int> expected)
    {
        var actual = Solution.PreOrder(root);

        Assert.Equal(expected, actual);
    }
}