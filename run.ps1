dotnet run -c Release

Copy-Item -Path .\BenchmarkDotNet.Artifacts\results -Destination .\results -Recurse
