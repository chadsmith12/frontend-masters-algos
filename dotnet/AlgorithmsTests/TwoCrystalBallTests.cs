using Shouldly;

namespace AlgorithmsTests
{
    public class TwoCrystalBallsTests
    {
        [Fact]
        public void WillFindFirstPlaceCrystalBallBreaks()
        {
            var items = new[] { false, false, false, false, false, false, true, true, true, true, true, true };
            var result = Algorithms.Algorithms.TwoCrystalBalls(items);

            result.ShouldBe(6);
        }
    }
}