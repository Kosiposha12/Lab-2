using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            string a = "Fun";
            int[] b = { 1, 2, 3 };
            var k = Fun(a, b);
            Console.WriteLine($"{k}");

            Console.ReadKey();
        }
        static object Fun(string str, int[] arr)
        {
            int max = arr[0], min = arr[0], sum = 0;
            foreach (int x in arr)
            {
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
                sum += x;
            }
            var cort = (max, min, sum, str[0]);
            return cort;
        }
    }
}
