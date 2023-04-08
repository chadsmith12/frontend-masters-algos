using Shouldly;

namespace AlgorithmsTests
{
    public class BubbleSortTests
    {
        [Fact]
        public void WillSortArrayInPlace()
        {
            var items = new[] { 5, 6, 1, 65, 32, 6453, 4534, 3, 5634, 555 };
            Algorithms.Algorithms.BubbleSort(items);

            items.ShouldBeInOrder();
        }
    }
}