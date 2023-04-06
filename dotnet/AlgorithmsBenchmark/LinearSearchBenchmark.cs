using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AlgorithmsBenchmark
{
    public class LinearSearchBenchmark
    {
        private const int N = 1000;
        private readonly int[] data;

        public LinearSearchBenchmark()
        {
            data = new int[N];
            var rand = new Random(69);
            for(int i = 0; i < N; i++)
            {
                data[i] = rand.Next(1000);
            }
        }

        [Benchmark]
        public bool LinearSearch()
        {
            return Algorithms.Algorithms.LinearSearch(data, 999);
        }
    }
}
