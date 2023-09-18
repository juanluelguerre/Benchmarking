using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace ElGuerre.Benchmarking.Memoized
{
    public class MemoizedBenchmark : IBenchmarck
    {
        private readonly List<List<int>> _sampleList = new()
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5 },
            new List<int> { 6, 7, 8 }
        };

        private readonly Func<List<List<int>>, IEnumerable<int>> memoizedSelectMany;


        public MemoizedBenchmark()
        {
            this.memoizedSelectMany = Memoize<List<List<int>>, IEnumerable<int>>(lists =>
                lists.SelectMany(list => list));
        }


        [Benchmark]
        public void FirstTry()
        {
            this.memoizedSelectMany(this._sampleList);
        }

        [Benchmark]
        public void SecondTry()
        {
            this.memoizedSelectMany(this._sampleList);
        }


        private static Func<T, TResult> Memoize<T, TResult>(Func<T, TResult> func)
        {
            var cache = new Dictionary<T, TResult>();
            return arg =>
            {
                if (!cache.TryGetValue(arg, out var result))
                {
                    result = func(arg);
                    cache[arg] = result;
                }

                return result;
            };
        }

        public Summary Run()
        {
            var summary = BenchmarkRunner.Run<MemoizedBenchmark>();
            return summary;
        }
    }
}
