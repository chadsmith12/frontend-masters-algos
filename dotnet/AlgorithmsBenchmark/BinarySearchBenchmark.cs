using BenchmarkDotNet.Attributes;

namespace AlgorithmsBenchmark
{
    public class BinarySearchBenchmark
    {
        private const int N = 1000;
        private readonly int[] data;

        public BinarySearchBenchmark()
        {
            data = new int[N];
            var rand = new Random(69);
            for (int i = 0; i < N; i++)
            {
                data[i] = rand.Next(1000);
            }
        }

        [Benchmark]
        public bool BinarySearch()
        {
            return Algorithms.Algorithms.LinearSearch(data, 420);
        }
    }
}
