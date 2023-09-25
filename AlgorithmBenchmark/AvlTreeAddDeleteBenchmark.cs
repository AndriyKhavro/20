using BalancedSearchTree;
using BenchmarkDotNet.Attributes;

namespace AlgorithmBenchmark;

public class AvlTreeAddDeleteBenchmark : BenchmarkBase
{
    [Benchmark]
    public AvlTree<int> Insert()
    {
        var collection = new AvlTree<int>();
        foreach (var value in Values)
        {
            collection.Insert(value);
        }
            
        return collection;
    }

    [Benchmark]
    public AvlTree<int> InsertAndDelete()
    {
        var collection = new AvlTree<int>();
        foreach (var value in Values)
        {
            collection.Insert(value);
        }

        foreach (var value in Values)
        {
            collection.Delete(value);
        }

        return collection;
    }
}