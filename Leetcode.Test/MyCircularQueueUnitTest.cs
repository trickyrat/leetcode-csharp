
using Xunit;

namespace Leetcode.Test;
public class MyCircularQueueUnitTest
{
    [Fact]
    public void Test()
    {
        MyCircularQueue myCircularQueue = new MyCircularQueue(3);
        Assert.True(myCircularQueue.EnQueue(1)); // return True
        Assert.True(myCircularQueue.EnQueue(2)); // return True
        Assert.True(myCircularQueue.EnQueue(3)); // return True
        Assert.False(myCircularQueue.EnQueue(4)); // return False
        Assert.Equal(3, myCircularQueue.Rear());     // return 3
        Assert.True(myCircularQueue.IsFull());   // return True
        Assert.True(myCircularQueue.DeQueue());  // return True
        Assert.True(myCircularQueue.EnQueue(4)); // return True
        Assert.Equal(4, myCircularQueue.Rear());     // return 4
    }
}
