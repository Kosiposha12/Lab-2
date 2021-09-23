using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void RemoveAt(ref int[] array,int index,int value, int index1)
        {
            int[] newArray = new int[array.Length - 1];
            for(int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;

            newArray = new int[array.Length + 1];
            newArray[index1] = value;
            for (int i = 0; i< index1; i++)
            {
                newArray[i] = array[i];
            }
            for (int i =index1; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;

            Console.Write("\nСодержимое массива равно: ");
            foreach (int x in array)
            {
                Console.Write($"{x}");
            }
        }
       
      

        static void Main(string[] args)
        {
            ////a)
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            //---------------------------------------------------------------------------------
            //b)

            int[] mas2 = { 1,4,6,2 };
            Console.Write("Содержимое массива равно: ");
            foreach (int i in mas2)
            {
                Console.Write($"{i}");
            }
            Console.Write("\nДлина Массива: " + mas2.Length);
            Console.Write("\nВведите позицию в массиве для удаления:");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите значение для вставки в массив:");
            int q2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите позицию для вставки в массив:");
            int q3 = Convert.ToInt32(Console.ReadLine());
            RemoveAt(ref mas2, q, q2,q3);


            //---------------------------------------------------------------------------------
            ////c)
            Console.Write("\nВведите количество чего-то: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чего-то: ");
            int g8 = Convert.ToInt32(Console.ReadLine());
            int[][] mas3 = new int[3][];
            mas3[0] = new int[] { g, g1, };
            mas3[1] = new int[] { g2, g3, g4 };
            mas3[2] = new int[] { g5, g6, g7, g8 };
            for (int n = 0; n < mas3.Length; n++)
            {
                Console.Write("Ряд({0}): ", n);
                for (int k = 0; k < mas3[n].Length; k++)
                {
                    Console.Write("{0} ", mas3[n][k]);
                }
                Console.WriteLine();
            }
            //d
           
        }
    }
}
