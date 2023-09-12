```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900HX with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method       | Size   | Max        | SortOrder  | Mean        | Error     | StdDev    |
|------------- |------- |----------- |----------- |------------:|----------:|----------:|
| **ContainsTrue** | **100000** | **100**        | **None**       |  **2,768.3 μs** |  **53.06 μs** |  **58.97 μs** |
| **ContainsTrue** | **100000** | **100**        | **Ascending**  |    **151.4 μs** |   **2.99 μs** |   **3.78 μs** |
| **ContainsTrue** | **100000** | **100**        | **Descending** |  **1,209.6 μs** |  **22.78 μs** |  **29.61 μs** |
| **ContainsTrue** | **100000** | **100000**     | **None**       | **12,266.3 μs** | **175.11 μs** | **146.22 μs** |
| **ContainsTrue** | **100000** | **100000**     | **Ascending**  |    **153.1 μs** |   **3.04 μs** |   **3.38 μs** |
| **ContainsTrue** | **100000** | **100000**     | **Descending** |  **4,055.3 μs** |  **48.82 μs** |  **45.67 μs** |
| **ContainsTrue** | **100000** | **1000000**    | **None**       | **13,065.0 μs** | **102.14 μs** |  **90.55 μs** |
| **ContainsTrue** | **100000** | **1000000**    | **Ascending**  |    **148.7 μs** |   **2.46 μs** |   **2.30 μs** |
| **ContainsTrue** | **100000** | **1000000**    | **Descending** |  **4,504.8 μs** |  **48.49 μs** |  **42.98 μs** |
| **ContainsTrue** | **100000** | **2147483647** | **None**       | **13,148.0 μs** | **143.88 μs** | **134.58 μs** |
| **ContainsTrue** | **100000** | **2147483647** | **Ascending**  |    **146.5 μs** |   **2.87 μs** |   **3.08 μs** |
| **ContainsTrue** | **100000** | **2147483647** | **Descending** |  **4,590.2 μs** |  **27.68 μs** |  **23.11 μs** |
