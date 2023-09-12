```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900HX with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method          | Size   | Max        | SortOrder  | Mean      | Error     | StdDev    |
|---------------- |------- |----------- |----------- |----------:|----------:|----------:|
| **Insert**          | **100000** | **100**        | **None**       |  **5.278 ms** | **0.1044 ms** | **0.2155 ms** |
| InsertAndDelete | 100000 | 100        | None       |  5.336 ms | 0.1019 ms | 0.1289 ms |
| **Insert**          | **100000** | **100**        | **Ascending**  |  **3.372 ms** | **0.0662 ms** | **0.0991 ms** |
| InsertAndDelete | 100000 | 100        | Ascending  |  6.774 ms | 0.1342 ms | 0.1697 ms |
| **Insert**          | **100000** | **100**        | **Descending** |  **3.036 ms** | **0.0586 ms** | **0.0761 ms** |
| InsertAndDelete | 100000 | 100        | Descending |  6.420 ms | 0.1237 ms | 0.1609 ms |
| **Insert**          | **100000** | **100000**     | **None**       | **23.697 ms** | **0.4731 ms** | **0.4858 ms** |
| InsertAndDelete | 100000 | 100000     | None       | 45.832 ms | 0.9156 ms | 0.9797 ms |
| **Insert**          | **100000** | **100000**     | **Ascending**  | **13.998 ms** | **0.2784 ms** | **0.4575 ms** |
| InsertAndDelete | 100000 | 100000     | Ascending  | 23.811 ms | 0.4739 ms | 0.6486 ms |
| **Insert**          | **100000** | **100000**     | **Descending** | **10.577 ms** | **0.2007 ms** | **0.1971 ms** |
| InsertAndDelete | 100000 | 100000     | Descending | 20.787 ms | 0.4065 ms | 0.6447 ms |
| **Insert**          | **100000** | **1000000**    | **None**       | **26.433 ms** | **0.5256 ms** | **0.6834 ms** |
| InsertAndDelete | 100000 | 1000000    | None       | 52.317 ms | 0.9039 ms | 0.8013 ms |
| **Insert**          | **100000** | **1000000**    | **Ascending**  | **14.815 ms** | **0.2887 ms** | **0.2700 ms** |
| InsertAndDelete | 100000 | 1000000    | Ascending  | 26.273 ms | 0.4886 ms | 0.4570 ms |
| **Insert**          | **100000** | **1000000**    | **Descending** | **11.739 ms** | **0.2085 ms** | **0.1951 ms** |
| InsertAndDelete | 100000 | 1000000    | Descending | 23.626 ms | 0.4157 ms | 0.3471 ms |
| **Insert**          | **100000** | **2147483647** | **None**       | **27.200 ms** | **0.5158 ms** | **0.5519 ms** |
| InsertAndDelete | 100000 | 2147483647 | None       | 53.420 ms | 1.0271 ms | 1.2227 ms |
| **Insert**          | **100000** | **2147483647** | **Ascending**  | **15.259 ms** | **0.3041 ms** | **0.3620 ms** |
| InsertAndDelete | 100000 | 2147483647 | Ascending  | 26.406 ms | 0.5159 ms | 0.6141 ms |
| **Insert**          | **100000** | **2147483647** | **Descending** | **11.837 ms** | **0.2295 ms** | **0.2550 ms** |
| InsertAndDelete | 100000 | 2147483647 | Descending | 23.136 ms | 0.4437 ms | 0.5770 ms |
