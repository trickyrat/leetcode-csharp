// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class BuildArrayUnitTest
{
    public static TheoryData<int[], int, IList<string>> Data
    {
        get
        {
            var data = new TheoryData<int[], int, IList<string>>
            {
                { [1, 3], 3, ["Push", "Push", "Pop", "Push"] },
                { [1, 2, 3], 3, ["Push", "Push", "Push"] },
                { [1, 2], 4, ["Push", "Push"] }
            };
            return data;
        }
    }


    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] targets, int n, IList<string> expected)
    {
        var actual = Solution.BuildArray(targets, n);
        Assert.Equal(expected, actual);
    }
}