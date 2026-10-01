using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    [MemoryDiagnoser]
    public class StringBenchmark
    {
        [Params(100, 1000, 10000, 100000)]
        public int Iterations;

        [Benchmark]
        public string StringConcatenation()
        {
            string result = "";

            for (int i = 0; i < Iterations; i++)
            {
                result +=
                    "Academy Schedule Analyzer";
            }

            return result;
        }

        [Benchmark]
        public string StringBuilderConcatenation()
        {
            StringBuilder result =
                new StringBuilder();

            for (int i = 0; i < Iterations; i++)
            {
                result.Append(
                    "Academy Schedule Analyzer");
            }

            return result.ToString();
        }
    }
}
