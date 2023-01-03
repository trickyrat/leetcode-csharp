// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class ExamRoomUnitTest
{

    [Fact]
    public void SingleTest()
    {
        ExamRoom er = new(10);
        Assert.Equal(0, er.Seat());
        Assert.Equal(9, er.Seat());
        Assert.Equal(4, er.Seat());
        Assert.Equal(2, er.Seat());
        er.Leave(4);
        Assert.Equal(5, er.Seat());
    }

}

