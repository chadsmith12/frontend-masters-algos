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

        public void Push(T value) 
        {
            var node = new Node(value);
            length++;

            if (this.head == null)
            {
                this.head = node;
                return;
            }

            var head = this.head;
            this.head = node;
            this.head.Previous = head;
        }

        public T Pop() 
        {
            if (this.head == null)
            {
                throw new InvalidOperationException("Can not pop when stack is empty");
            }

            length--;

            var head = this.head;
            this.head = head.Previous;

            return head.Value;
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
