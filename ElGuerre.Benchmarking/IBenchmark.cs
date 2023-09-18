using BenchmarkDotNet.Reports;

namespace ElGuerre.Benchmarking;

public interface IBenchmarck
{
    public Summary Run();
}
