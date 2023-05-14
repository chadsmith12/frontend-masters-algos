using Shouldly;

namespace AlgorithmsTests
{
    public class LinkedListTests
    {
        [Fact]
        public void CanPushOntoEmptyListTest()
        {
            var linkedListed = new Algorithms.LinkedList.LinkedList<int>();
            linkedListed.Add(1);

            linkedListed.Length.ShouldBe(1);
        }

        [Fact]
        public void CanPushToNonEmptyListTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);

            linkedList.Length.ShouldBe(2);
        }

        [Fact]
        public void CanRemoveLastNodeOnListTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);

            linkedList.RemoveLast();
            linkedList.Length.ShouldBe(1);
        }

        [Fact]
        public void CanMakeListEmptyByRemvoingLastNodeTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);

            linkedList.RemoveLast();
            linkedList.Length.ShouldBe(0);
        }

        [Fact]
        public void CanRemoveFirstNodeTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.RemoveFirst();
            linkedList.Length.ShouldBe(2);
        }

        [Fact]
        public void CanAddNodeToFrontTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.AddFirst(2);

            linkedList.Length.ShouldBe(2);
        }

        [Fact]
        public void CanGetFirstIndexTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            var item = linkedList.GetAtIndex(0);

            item.ShouldBe(1);
        }

        [Fact]
        public void CanGetLastIndexText()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            var item = linkedList.GetAtIndex(1);

            item.ShouldBe(2);
        }

        [Fact]
        public void WillThrowArgumentOutOfRangeExceptionTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);

            Should.Throw(() => linkedList.GetAtIndex(3), typeof(ArgumentOutOfRangeException));
        }

        [Fact]
        public void ContainsWillReturnTrueTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);

            var item = linkedList.Contains(1);
            item.ShouldBeTrue();
        }

        [Fact]
        public void ContainsWillReturnFalseTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);

            var item = linkedList.Contains(2);
            item.ShouldBeFalse();
        }

        [Fact]
        public void ContainsWillReturnFalseOnEmptyTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();

            var item = linkedList.Contains(2);
            item.ShouldBeFalse();
        }

        [Fact]
        public void ShouldClearTheLinkedLinkTest()
        {
            var linkedListed = new Algorithms.LinkedList.LinkedList<int>();
            linkedListed.Add(1);
            linkedListed.Add(2);
            linkedListed.Add(3);

            linkedListed.Clear();

            linkedListed.Length.ShouldBe(0);
        }

        [Fact]
        public void ShouldRemoveItemWhenHeadTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);

            var removed = linkedList.Remove(1);

            removed.ShouldBeTrue();
        }

        [Fact]
        public void ShouldRemoveItemWhenTailTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);

            var removed = linkedList.Remove(2);

            removed.ShouldBeTrue();
        }

        [Fact]
        public void ShouldRemoveItemTest()
        {
            var linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            var removed = linkedList.Remove(2);

            removed.ShouldBeTrue();
        }
    }
}
