namespace Algorithms.Queue
{
    public class Queue<T>
    {
        private class Node
        {
            public T Value;
            public Node? Next;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? head;
        private Node? tail;
        private int length;

        public Queue()
        {
            this.head = this.tail = null;
            this.length = 0;
        }

        public void Enqueue(T item)
        {
            var node = new Node(item);
            this.length++;
            // we don't have anything yet, insert as first element
            if (this.tail == null)
            {
                this.tail = this.head = node;
                return;
            }

            // point the tail to the new node we just created
            this.tail.Next = node;
            this.tail = node;
            
        }

        public T Deque()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException("Attempt to deque when the queue is already empty");
            }

            this.length--;

            var head = this.head;
            this.head = this.head.Next;

            return head.Value;
        }

        public T? Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Attempt to peek in the queue when the queue is already empty");
            }

            return this.head.Value;
        }

        public int Length { get { return this.length; } }
    }
}
