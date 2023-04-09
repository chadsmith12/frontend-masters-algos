namespace Algorithms.ArrayList
{
    public class ArrayList<T>
    {
        private int capacity;
        private int length;
        private T[] buffer;

        public ArrayList(int capacity)
        {
            this.capacity = capacity;
            this.length = 0;
            this.buffer = new T[capacity];
        }

        public void Push(T item)
        {
            // do we need more memory?
            if (this.length == capacity)
            {
                Reallocate();
            }

            buffer[this.length] = item;
            this.length++;
        }

        public T Pop()
        {
            if (length == 0)
            {
                throw new InvalidOperationException("Can not pop from an empty ArrayList");
            }

            var value = buffer[this.length - 1];
            this.length--;

            return value;
        }

        private void Reallocate()
        {
            this.capacity *= 2;
            var newBuffer = new T[this.capacity];
            Array.Copy(buffer, newBuffer, buffer.Length);
            this.buffer = newBuffer;
        }

        public int Capacity { get { return this.capacity; } }
        public int Length { get { return this.length; } }
    }
}
