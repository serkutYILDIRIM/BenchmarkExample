using BenchmarkDotNet.Attributes;

namespace BenchmarkExample
{
    [MemoryDiagnoser(false)]
    public class BenchmarkTest
    {

        [Benchmark]
        public int FindMaxNumberWithOldWay()
        {
            var numbers = new int[1000];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            //Old Way Method Syntax
            var maxNumber = numbers.OrderByDescending(x => x).FirstOrDefault();

            return maxNumber;
        }

        [Benchmark]
        public int MaxByMethod()
        {
            var numbers = new int[1000];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            //MaxBy Method Syntax
            var maxNumber = numbers.MaxBy(x => x);

            return maxNumber;
        }
    }
}


