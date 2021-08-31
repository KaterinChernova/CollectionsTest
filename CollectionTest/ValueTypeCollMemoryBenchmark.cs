using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace CollectionTest
{
    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 10, targetCount: 15)]
    public class ValueTypeCollMemoryBenchmark
    {
        private const int Count = 100000;

        [Benchmark]
        public void ArrayMemoryTest()
        {
            var array = new int[Count];

            for (var i = 0; i < Count; i++)
            {
                array[i] = i;
            }
        }

        [Benchmark]
        public void HashsetMemoryTest()
        {
            var hashset = new HashSet<int>(Count);

            for (var i = 0; i < Count; i++)
            {
                hashset.Add(i);
            }
        }

        [Benchmark]
        public void ListMemoryTest()
        {
            var list = new List<int>(Count);

            for (var i = 0; i < Count; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void DictionaryMemoryTest()
        {
            var dict = new Dictionary<int, int>(Count);

            for (var i = 0; i < Count; i++)
            {
                dict.Add(i, i);
            }
        }
    }
}
