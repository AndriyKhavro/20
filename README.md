### Run benchmarks in Release mode
```
dotnet run -c Release
```

### Benchmark results

[AVL tree Add and Delete](./results/AlgorithmBenchmark.AvlTreeAddDeleteBenchmark-report-github.md)

[AVL tree Contains](./results/AlgorithmBenchmark.AvlTreeContainsBenchmark-report-github.md)

[Counting sort](./results/AlgorithmBenchmark.CountingSortBenchmark-report-github.md)

AVL tree performs better on sorted dataset. Add and Delete operations perform slightly better when data set is sorted in Descending order. Contains is much better when the items were inserted in Ascending order.

Counting sort complexity grows with maximum number in array. Because its running duration is proportional to the number of items and the difference between the maximum and minimum key values, it is only suited for direct usage when the number of items is not much more than the variation in keys.
