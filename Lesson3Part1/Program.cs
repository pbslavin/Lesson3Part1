using System;
using System.Threading.Tasks;
using ThreadingAndTasks;

namespace Lesson3Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci2 = new Fibonacci(2);
            Fibonacci fibonacci4 = new Fibonacci(4);
            Fibonacci fibonacci8 = new Fibonacci(8);
            Fibonacci fibonacci16 = new Fibonacci(16);

            Task task1 = new Task(() =>
            {
                Console.WriteLine(($"The 2nd Fibonacci number is {fibonacci2.Calculate()}"));
            });

            Task task2 = new Task(() =>
            {
                Console.WriteLine(($"The 4th Fibonacci number is {fibonacci4.Calculate()}"));
            });
            Task task3 = new Task(() =>
            {
                Console.WriteLine(($"The 8th Fibonacci number is {fibonacci8.Calculate()}"));
            });
            Task task4 = new Task(() =>
            {
                Console.WriteLine($"The 16th Fibonacci number is {fibonacci16.Calculate()}");
            });

            task1.Start();
            task1.Wait();
            task2.Start();
            task2.Wait();
            task3.Start();
            task3.Wait();
            task4.Start();
            task4.Wait();

            foreach (int element in Fibonacci.cache)
            {
                Console.WriteLine(element);
            }
        }
    }
}
