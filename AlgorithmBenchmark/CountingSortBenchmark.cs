using BenchmarkDotNet.Attributes;

namespace AlgorithmBenchmark;

////[InvocationCount(InvocationsPerIteration)]
public class CountingSortBenchmark : BenchmarkBase
{
    ////private const int InvocationsPerIteration = 5000;
    ////private int[][] _arrays = Array.Empty<int[]>();

    ////protected override void AfterValuesInitialized()
    ////{
    ////    _arrays = Enumerable.Range(0, InvocationsPerIteration).Select(_ => new int[Values.Length]).ToArray();

    ////    foreach (var array in _arrays)
    ////        Array.Copy(sourceArray: Values, destinationArray: array, length: Values.Length);

    ////    // we dont use Debug.Assert here because this code will be executed mostly in Release
    ////    if (_arrays.Any(collection => collection.Length != Values.Length) ||
    ////        _arrays.Length != InvocationsPerIteration)
    ////    {
    ////        throw new InvalidOperationException();
    ////    }
    ////}

    [Benchmark]
    public int[] Sort()
    {
        return SortUtil.CountingSort(Values);
    }
}