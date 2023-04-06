using Shouldly;

namespace AlgorithmsTests
{
    public class LinearSearchTests
    {
        [Fact]
        public void LinearSearchReturnsTrueShouldFindValue()
        {
            var items = new[] { 1, 2, 3 };
            var result = Algorithms.Algorithms.LinearSearch(items, 1);

            result.ShouldBeTrue();
        }

        [Fact]
        public void LinearSearchReturnsFalseShouldNotFindValue()
        {
            var items = new[] { 1 };
            var result = Algorithms.Algorithms.LinearSearch(items, 2);

            result.ShouldBeFalse();
        }
    }
}