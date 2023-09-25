using BenchmarkDotNet.Attributes;

namespace AlgorithmBenchmark;

public abstract class BenchmarkBase
{
    protected int[] Values = Array.Empty<int>();

    [Params(100_000)]
    public int Size;

    public const int Min = 0;

    [Params(100, 100_000, 1_000_000, int.MaxValue)]
    public int Max;

    [Params(SortOrder.None, SortOrder.Ascending, SortOrder.Descending)]
    public SortOrder SortOrder;

    [GlobalSetup]
    public void Setup()
    {
        Values = DataSetGenerator.Generate(Min, Max, Size);

        if (SortOrder == SortOrder.Ascending)
        {
            Values = Values.OrderBy(x => x).ToArray();
            return;
        }

        if (SortOrder == SortOrder.Descending)
        {
            Values = Values.OrderByDescending(x => x).ToArray();
        }

        AfterValuesInitialized();
    }

    protected virtual void AfterValuesInitialized()
    {
    }
}