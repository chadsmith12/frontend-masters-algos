using Shouldly;

namespace AlgorithmsTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void BinarySearchReturnsTrueShouldFindValue()
        {
            var items = new[] { 1, 2, 3 };
            var result = Algorithms.Algorithms.BinarySearch(items, 3);

            result.ShouldBeTrue();
        }

        [Fact]
        public void BinarySearchhReturnsFalseShouldNotFindValue()
        {
            var items = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var result = Algorithms.Algorithms.LinearSearch(items, 10);

            result.ShouldBeFalse();
        }
    }
}