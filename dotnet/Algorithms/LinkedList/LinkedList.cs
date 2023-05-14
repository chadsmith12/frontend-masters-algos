using System.Diagnostics;

namespace Algorithms.LinkedList
{
    public class LinkedListNode<T>
    {
        public T Value;
        public LinkedListNode<T>? Next;
        public LinkedListNode<T>? Previous;
        public LinkedListNode(T value) {  Value = value; }
    }


    public class LinkedList<T>
    {
        private LinkedListNode<T>? _head;
        private LinkedListNode<T>? _tail;

        public LinkedList()
        {
            Length = 0;
            _head = null;
            _tail = null;
        }

        public void Add(T value)
        {
            var node = new LinkedListNode<T>(value);
            Length++;

            if (_head == null || _tail == null)
            {
                _head = node;
                _tail = node;
                return;
            }

            _tail.Next = node;
            node.Previous = _tail;
            _tail = node;
        }

        public void AddFirst(T value)
        {
            if (Length == 0)
            {
                Add(value);
                return;
            }

            Debug.Assert(_head != null, $"${nameof(_head)} should not be null");
            Length++;
            var node = new LinkedListNode<T>(value);
            _head.Previous = node;
            node.Next = _head;
            _head = node;
        }

        public void RemoveLast()
        {
            CheckLinkedListNotEmpty();

            Length--;
            if (Length == 0)
            {
                _head = null;
                _tail = null;
                return;
            }

            Debug.Assert(_tail!.Previous != null, "The tail's previous can't be null!");
            var beforeTail = _tail.Previous;
            beforeTail.Next = null;
            _tail = beforeTail;
        }

        public void RemoveFirst()
        {
            CheckLinkedListNotEmpty();

            if (Length == 1)
            {
                RemoveLast();
                return;
            }
            Length--;
            var afterHead = _head!.Next;
            _head.Next!.Previous = null;
            _head = afterHead;
        }

        public T GetAtIndex(int index)
        {
            if (Length == 0)
            {
                throw new InvalidOperationException("Linked List is Empty");
            }
            if (index >= Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var current = _head;
            for(var i = 0; i < index; i++)
            {
                Debug.Assert(current != null, $"${nameof(current)} can't be null.");
                current = current.Next;
            }

            Debug.Assert(current != null, $"${nameof(current)} can't be null.");
            return current.Value;
        }

        public bool Contains(T value)
        {
            if (Length == 0 || _head == null)
            {
                return false;
            }

            var comparer = EqualityComparer<T>.Default;
            var current = _head;
            while(current != null)
            {
                if (comparer.Equals(current.Value, value))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        private void CheckLinkedListNotEmpty()
        {
            if (_head == null || _tail == null)
            {
                throw new InvalidOperationException("Linked List Is Empty");
            }
        }

        public void Clear()
        {
            var current = _head;

            while(current != null)
            {
                var temp = current;
                current = current.Next;
                temp.Previous = null;
                temp.Next = null;
            }

            _head = null;
            _tail = null;
            Length = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ArgumentNullException.ThrowIfNull(nameof(array));
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            }
            if (arrayIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), arrayIndex, "The index passed in bigger than the collection");
            }

        }

        public bool Remove(T item)
        {
            var current = _head;
            var comparer = EqualityComparer<T>.Default;

            while (current != null)
            {
                if (comparer.Equals(current.Value, item))
                {
                    if (_head == current)
                    {
                        RemoveFirst();
                        return true;
                    }
                    if (_tail == current)
                    {
                        RemoveLast();
                        return true;
                    }
                    current.Previous!.Next = current.Next;
                    current.Next!.Previous = current.Previous;
                    Length--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public int Length { get; private set; }
    }
}
