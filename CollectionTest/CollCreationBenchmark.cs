using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace CollectionTest
{
    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 10, targetCount: 15)]
    public class CollCreationBenchmark
    {
        private const int Count = 100000;

        [Benchmark(Baseline = true)]
        public void ArrayMemoryTest()
        {
            var array = new int[Count];

            Console.WriteLine(array.Length);
        }

        [Benchmark]
        public void HashsetMemoryTest()
        {
            var hashset = new HashSet<int>(Count);

            Console.WriteLine(hashset.Count);
        }

        [Benchmark]
        public void ListMemoryTest()
        {
            var list = new List<int>(Count);

            Console.WriteLine(list.Count);
        }

        [Benchmark]
        public void DictionaryMemoryTest()
        {
            var dict = new Dictionary<int, int>(Count);

            Console.WriteLine(dict.Count);
        }
    }
}
