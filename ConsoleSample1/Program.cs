using System;

namespace ConsoleSample1
{
    public delegate string MyMethodType(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var func = new MyMethodType(Add);

            var func1 = new Func<int, int, string>(Add);

            Console.ReadKey();
        }

        static string Add(int x, int y)
        {
            return $"{x + y}";
        }
    }
}
