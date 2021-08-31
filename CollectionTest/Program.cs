using BenchmarkDotNet.Running;
using System;

namespace CollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
             // BenchmarkRunner.Run<ValueTypeCollMemoryBenchmark>();
            // BenchmarkRunner.Run<RefTypeCollMemoryBenchmark>();
            // BenchmarkRunner.Run<OneRefTypeCollMemoryBenchmark>();
             BenchmarkRunner.Run<CollCreationBenchmark>();

            Console.ReadKey();
        }
    }
}
