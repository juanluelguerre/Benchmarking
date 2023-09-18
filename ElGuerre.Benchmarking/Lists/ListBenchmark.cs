using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace ElGuerre.Benchmarking.Lists;

public class ListBenchmark : IBenchmarck
{
    [Benchmark]
    public void ArrayEmpty()
    {
        var emptyArray = Array.Empty<string>();
    }

    [Benchmark]
    public void ListEmpty()
    {
        var emptyList = new List<string>();
    }


    [Benchmark]
    public void ArrayInitialized()
    {
        var list = new string[] { "Data1", "Data2", "Data3", "Data4", "Data5" };
    }

    [Benchmark]
    public void ListEmptyInitializedAndAdd()
    {
        var emptyList = new List<string>();
        emptyList.Add("Data1");
        emptyList.Add("Data2");
        emptyList.Add("Data3");
        emptyList.Add("Data4");
        emptyList.Add("Data5");
    }

    [Benchmark]
    public void ListInitialized()
    {
        var emptyList = new List<string>()  { "Data1", "Data2", "Data3", "Data4", "Data5" };
    }

    public Summary Run()
    {
        var summary = BenchmarkRunner.Run<ListBenchmark>();
        return summary;
    }
}


