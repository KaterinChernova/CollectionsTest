using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace CollectionTest
{
    class Model
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }

    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 10, targetCount: 15)]
    public class RefTypeCollMemoryBenchmark
    {
        private const int Count = 100000;

        [Benchmark]
        public void ArrayMemoryTest()
        {
            var array = new Model[Count];

            for (var i = 0; i < Count; i++)
            {
                array[i] = new Model
                {
                    Id = i,
                    Name = "test",
                    Description = "testDesc"
                };
            }
        }

        [Benchmark]
        public void HashsetMemoryTest()
        {
            var hashset = new HashSet<Model>(Count);

            for (var i = 0; i < Count; i++)
            {
                hashset.Add(new Model
                {
                    Id = i,
                    Name = "test",
                    Description = "testDesc"
                });
            }
        }

        [Benchmark]
        public void ListMemoryTest()
        {
            var list = new List<Model>(Count);

            for (var i = 0; i < Count; i++)
            {
                list.Add(new Model
                {
                    Id = i,
                    Name = "test",
                    Description = "testDesc"
                });
            }
        }

        [Benchmark]
        public void DictionaryMemoryTest()
        {
            var dict = new Dictionary<Model, Model>(Count);

            for (var i = 0; i < Count; i++)
            {
                var model = new Model
                {
                    Id = i,
                    Name = "test",
                    Description = "testDesc"
                };
                dict.Add(model, model);
            }
        }
    }
}
