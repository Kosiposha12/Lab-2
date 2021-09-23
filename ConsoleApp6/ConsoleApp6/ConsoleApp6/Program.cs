using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Main1();
            Main2();

        }
        static void Main1()
        {
            int a = checked(123);
            Console.WriteLine(a);
        }
        static void Main2() {
            int a = unchecked(123 + 23);
            Console.WriteLine(a);
        }
    }
}
