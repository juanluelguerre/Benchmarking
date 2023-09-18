using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace ElGuerre.Benchmarking.AsyncAwait;

[MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
[MemoryDiagnoser]
public class AsyncAwaitBenchmark : IBenchmarck
{
    [Benchmark]
    public async Task TaskTest()
    {
        await (new RestaurantMediator()).TaskService();
    }


    [Benchmark]
    public async Task AwaitTest()
    {
        await (new RestaurantMediator()).AwaitService();
    }

    public Summary Run()
    {
        //var waiter = new TaskWaiter();
        //var chef = new TaskChef();
        //var customer = new TaskCustomer();

        //var serveSalad = waiter.ServeSalad();
        //Console.WriteLine("start cooking chicken");
        //var chicken = chef.CookChicken();
        //Console.WriteLine(await serveSalad);
        //Console.WriteLine(await customer.HaveSalad());
        //Console.WriteLine(await chicken);

        var summary = BenchmarkRunner.Run<AsyncAwaitBenchmark>();
        return summary;

    }
}

