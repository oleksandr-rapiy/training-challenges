using Xunit;

namespace Training.LeetCode.MyStackSolution
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/implement-stack-using-queues
    /// 
    /// Example 1:
    /// MyStack myStack = new MyStack();
    /// myStack.push(1);
    /// myStack.push(2);
    /// myStack.top(); // return 2
    /// myStack.pop(); // return 2
    /// myStack.empty(); // return False
    /// 
    /// <br/>
    /// 
    /// Status: "Accepted"
    /// 
    /// </summary>
    public class MyStack
    {
        private Queue<int> _queue;

        public MyStack()
        {
            _queue = new Queue<int>();
        }

        public void Push(int x)
        {
            _queue.Dequeue();
            _queue.Enqueue(x);
        }

        public int Pop()
        {
            var copy = _queue.ToList();
            var last = copy[_queue.Count - 1];
            copy.RemoveAt(_queue.Count - 1);

            _queue = new Queue<int>(copy);

            return last;
        }

        public int Top()
        {
            return _queue.Last();
        }

        public bool Empty()
        {
            return _queue.Count == 0;
        }
    }


    public class MyStackTests
    {
        [Fact]
        public void IsPushMethodValid()
        {
            // Arrange
            var stack = new MyStack();

            // Act 
            stack.Push(10);
            stack.Push(11);

            var result = stack.Top();

            // Assert
            Assert.Equal(11, result);
        }

        [Fact]
        public void IsTopAndPopMethodValid()
        {
            // Arrange
            var stack = new MyStack();

            // Act 
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);

            var top1 = stack.Top();
            var pop = stack.Pop();
            var top2 = stack.Top();

            // Assert
            Assert.Equal(12, top1);
            Assert.Equal(12, pop);
            Assert.Equal(11, top2);
        }
    }
}
