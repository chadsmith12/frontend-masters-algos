namespace Algorithms
{
    public class Stack<T>
    {
        private class Node
        {
            public T Value;
            public Node? Previous;

            public Node(T value) { Value = value; }
        }

        private int length = 0;
        private Node? head = null;
        private Node? tail = null;

        public void Push(T value) 
        {
            var node = new Node(value);
            length++;

            if (this.tail == null)
            {
                this.head = node;
                this.tail = node;
                return;
            }

            var tail = this.tail;
            this.tail = node;
            this.tail.Previous = tail;
        }

        public T Pop() 
        {
            if (this.tail == null)
            {
                throw new InvalidOperationException("Can not pop when stack is empty");
            }

            length--;

            var tail = this.tail;
            this.tail = tail.Previous;

            return tail.Value;
        }

        public T Peek() 
        {
            if (head == null)
            {
                throw new InvalidOperationException("Can not peek wihen stack is empty");
            }

            return head.Value;
        }

        public int Length { get { return length; } }
    }
}
