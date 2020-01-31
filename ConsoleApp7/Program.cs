using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sub(int.Parse("21"), 42 / 2));
        }
        static int sub(int x, int y)
        {
            return x - y;
        }
    }
}
