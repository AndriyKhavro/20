using BalancedSearchTree;
using BenchmarkDotNet.Attributes;

namespace AlgorithmBenchmark;

public class AvlTreeContainsBenchmark : BenchmarkBase
{
    private readonly AvlTree<int> _tree = new();
    private int[] _randomValues = Array.Empty<int>();

    protected override void AfterValuesInitialized()
    {
        foreach (var value in Values)
        {
            _tree.Insert(value);
        }

        _randomValues = DataSetGenerator.Generate(int.MinValue, int.MaxValue, Size);
    }

    [Benchmark]
    public bool ContainsTrue()
    {
        bool result = false;
        foreach (var value in Values)
        {
            result ^= _tree.Contains(value);
        }

        return result;
    }

    public bool ContainsRandom()
    {
        bool result = false;
        foreach (var value in _randomValues)
        {
            result ^= _tree.Contains(value);
        }

        return result;
    }
}