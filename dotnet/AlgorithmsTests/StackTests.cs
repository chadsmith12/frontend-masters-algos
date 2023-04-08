using Shouldly;

namespace AlgorithmsTests
{
    public class StackTests
    {
        [Fact]
        public void PushFirstItemWilHaveLengthOfOne()
        {
            var queue = new Algorithms.Stack<int>();
            queue.Push(1);

            queue.Length.ShouldBe(1);
        }

        [Fact]
        public void PushTwoTimesWillhaveLenthOfTwo()
        {
            var stack = new Algorithms.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Length.ShouldBe(2);
        }

        [Fact]
        public void PeekWillReturnValue()
        {
            var stack = new Algorithms.Stack<int>();
            stack.Push(1);

            stack.Peek().ShouldBe(1);
        }

        [Fact]
        public void PeekOnEmptyQueueWillThrow()
        {
            var stack = new Algorithms.Stack<int>();
            Should.Throw(() => stack.Peek(), typeof(InvalidOperationException));
        }

        [Fact]
        public void PoppingWillReturnFirstValue()
        {
            var stack = new Algorithms.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(32);

            stack.Pop().ShouldBe(32);
        }

        [Fact]
        public void PoppingWillChangeLength()
        {
            var stack = new Algorithms.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            stack.Length.ShouldBe(1);
        }

        [Fact]
        public void PoppingWillRemoveValue()
        {
            var stack = new Algorithms.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            var value = stack.Pop();

            value.ShouldBe(2);
            stack.Peek().ShouldBe(1);
        }
    }
}
