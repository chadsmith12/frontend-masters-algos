using Shouldly;

namespace AlgorithmsTests
{
    public class QueueTests
    {
        [Fact]
        public void EnqueueingFirstItemWilHaveLengthOfOne()
        {
            var queue = new Algorithms.Queue.Queue<int>();
            queue.Enqueue(1);

            queue.Length.ShouldBe(1);
        }

        [Fact]
        public void EnqueingTwoTimesWillhaveLenthOfTwo()
        {
            var queue = new Algorithms.Queue.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Length.ShouldBe(2);
        }

        [Fact]
        public void PeekWillReturnValue()
        {
            var queue = new Algorithms.Queue.Queue<int>();
            queue.Enqueue(1);

            queue.Peek().ShouldBe(1);
        }

        [Fact]
        public void PeekOnEmptyQueueWillThrow()
        {
            var queue = new Algorithms.Queue.Queue<int>();
            Should.Throw(() => queue.Peek(), typeof(InvalidOperationException));
        }

        [Fact]
        public void DequeWillReturnFirstValue()
        {
            var queue = new Algorithms.Queue.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Deque().ShouldBe(1);
        }

        [Fact]
        public void DequeWillChangeLength()
        {
            var queue = new Algorithms.Queue.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Deque();

            queue.Length.ShouldBe(1);
        }

        [Fact]
        public void DequeingWillRemoveValue()
        {
            var queue = new Algorithms.Queue.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Deque();

            queue.Peek().ShouldBe(2);
        }
    }
}
