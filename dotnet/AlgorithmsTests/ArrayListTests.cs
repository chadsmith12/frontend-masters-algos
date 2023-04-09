using Algorithms.ArrayList;
using Shouldly;

namespace AlgorithmsTests
{
    public class ArrayListTests
    {
        [Fact]
        public void ArrayListHasInitialCapacity()
        {
            var list = new ArrayList<int>(4);

            list.Capacity.ShouldBe(4);
        }

        [Fact]
        public void CanPushItemInArrayList()
        {
            var list = new ArrayList<int>(4);
            list.Push(2);

            list.Length.ShouldBe(1);
        }

        [Fact]
        public void CanPopItemFromArrayList()
        {
            var list = new ArrayList<int>(4);
            list.Push(2);
            list.Push(4);

            var value = list.Pop();

            value.ShouldBe(4);
        }

        [Fact]
        public void ArrayListCanResize()
        {
            var list = new ArrayList<int>(2);
            list.Push(1);
            list.Push(2);
            list.Push(3);

            list.Capacity.ShouldBe(4);
        }
    }
}
