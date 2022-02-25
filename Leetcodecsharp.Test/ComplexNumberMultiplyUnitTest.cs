// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class ComplexNumberMultiplyUnitTest
    {

        [Theory]
        [InlineData("1+1i", "1+1i", "0+2i")]
        [InlineData("1+-1i", "1+-1i", "0+-2i")]
        public void MultipleDataTest(string num1, string num2, string expected)
        {
            string actual = Solution.ComplexNumberMultiply(num1, num2);
            Assert.Equal(expected, actual);
        }
    }
}
