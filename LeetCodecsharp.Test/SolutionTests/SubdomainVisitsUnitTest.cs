// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class SubdomainVisitsUnitTest
{
    private readonly Solution _solution;

    public SubdomainVisitsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new string[] { "9001 discuss.leetcode.com" }, new string[] { "9001 leetcode.com", "9001 discuss.leetcode.com", "9001 com" })]
    [InlineData(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" }, new string[] { "901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com", "951 com" })]
    public void Test(string[] cpdomains, IList<string> expected)
    {
        var actual = _solution.SubdomainVisit(cpdomains);
        actual = actual.OrderBy(x => x).ToList();
        expected = expected.OrderBy(x => x).ToList();
        Assert.Equal(expected, actual);
    }
}