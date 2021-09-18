using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Leetcodecsharp;

namespace Leetcodecsharp.Test
{
    public class MinStackUnitTest
    {
        [Fact]
        public void Test()
        {
            MinStack min = new MinStack();
            min.Push(-2);
            min.Push(0);
            min.Push(-3);
            Assert.Equal(-3, min.GetMin());
            min.Pop();
            Assert.Equal(0, min.Top());
            Assert.Equal(-2, min.GetMin());
        }
    }
}
