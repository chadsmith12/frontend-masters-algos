using BenchmarkDotNet.Attributes;

namespace AlgorithmsBenchmark
{
    public class AlgorithmsBenchmark
    {
        private const int N = 1000;
        private readonly int[] data;
        private readonly bool[] breaks;
        private readonly List<int> dataToSort;
        private readonly List<int> dataToOrder;

        public AlgorithmsBenchmark()
        {
            data = new int[N];
            breaks = new bool[N];
            var rand = new Random(69);
            for(int i = 0; i < N; i++)
            {
                data[i] = rand.Next(1000);
            }

            var breakValue = rand.Next(1000);
            for (int i = 0; i < N; i++)
            {
                breaks[i] = i >= breakValue;
            }
            dataToSort = data.ToList();
            dataToOrder = data.ToList();
        }

        [Benchmark]
        public bool LinearSearch()
        {
            return Algorithms.Algorithms.LinearSearch(data, 999);
        }

        [Benchmark]
        public bool BinarySearch()
        {
            return Algorithms.Algorithms.BinarySearch(data, 999);
        }

        [Benchmark]
        public int CrystalBallsProblem()
        {
            return Algorithms.Algorithms.TwoCrystalBalls(breaks);
        }

        [Benchmark]
        public void BubbleSort()
        {
            Algorithms.Algorithms.BubbleSort(data);
        }

        [Benchmark]
        public void QuickSort()
        {
            Algorithms.Algorithms.QuickSort(data);
        }
    }
}
