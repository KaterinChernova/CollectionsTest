using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace CollectionTest
{
    class OneModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }

    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 10, targetCount: 15)]
    public class OneRefTypeCollMemoryBenchmark
    {
        private const int Count = 100000;

        [Benchmark]
        public void ArrayMemoryTest()
        {
            var array = new Model[Count];
            var model = new Model
            {
                Id = 1,
                Name = "test",
                Description = "testDesc"
            };

            for (var i = 0; i < Count; i++)
            {
                array[i] = model;
            }
        }

        [Benchmark]
        public void HashsetMemoryTest()
        {
            var hashset = new HashSet<Model>(Count);
            var model = new Model
            {
                Id = 1,
                Name = "test",
                Description = "testDesc"
            };

            for (var i = 0; i < Count; i++)
            {
                hashset.Add(model);
            }
        }

        [Benchmark]
        public void ListMemoryTest()
        {
            var list = new List<Model>(Count);
            var model = new Model
            {
                Id = 1,
                Name = "test",
                Description = "testDesc"
            };

            for (var i = 0; i < Count; i++)
            {
                list.Add(model);
            }
        }

        [Benchmark]
        public void DictionaryMemoryTest()
        {
            var dict = new Dictionary<int, Model>(Count);
            var model = new Model
            {
                Id = 1,
                Name = "test",
                Description = "testDesc"
            };

            for (var i = 0; i < Count; i++)
            {
                dict.Add(i, model);
            }
        }
    }
}
