// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ConnectUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new BinaryTreeNode(),
            new BinaryTreeNode()
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(BinaryTreeNode input, BinaryTreeNode expected)
    {
        var actual = Solution.Connect(input);
        //Assert.Equal(expected, actual);
    }
}
