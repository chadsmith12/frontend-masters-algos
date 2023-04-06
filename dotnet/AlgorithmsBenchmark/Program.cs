using AlgorithmsBenchmark;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<LinearSearchBenchmark>();
var binarySearch = BenchmarkRunner.Run<BinarySearchBenchmark>();