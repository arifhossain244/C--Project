using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Evidance_5_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 6, 5, 4, 7 };
            for (var i = 0; i < numbers.Length; i++)
            {
                CallFact(numbers[i], $"{numbers[i]}!=");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public static async void CallFact(int x, string label)
        {
            long f = await FactorialAsync(x);
            Console.WriteLine($"{label}{f}");
        }
        public static async Task<long> FactorialAsync(int n)
        {
            Console.WriteLine($"Th: {Thread.CurrentThread.ManagedThreadId} starts calculating factorial of {n}...");
            long fact = 1;
            await Task.Run(() =>
            {
                Random rnd = new Random();
                for (var i = 1; i <= n; i++)
                {
                    fact *= i;
                    Task.Delay(250).Wait();
                }
            });
            return fact;
        }
    }
}
