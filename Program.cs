using AlgorithmBenchmark;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<AvlTreeAddDeleteBenchmark>();
BenchmarkRunner.Run<AvlTreeContainsBenchmark>();
BenchmarkRunner.Run<CountingSortBenchmark>();
