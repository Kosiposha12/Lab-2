using System;

namespace ConsoleApp4
{
    class Program
    {
        static Tuple<int, string, char, string, ulong> CreateCortage(string name)
        {
            int len = name.Length;
            string s = "My first name is " + name;
            char ch = (char)(name[0]);
            string s1 = "Your name is " + name + ",it's true";
            ulong l1 = 1234567890054;
            return Tuple.Create<int, string, char, string, ulong>(len, s, ch,s1,l1);
        }


        static void Main(string[] args)
        {
            //(int, string, char, string, ulong) var1 = (g.Length, "My first name is " + g, (char)(g[0]), "Your name is " + g + ",it's true");
            //B)
            Console.Write("Введите ваше имя: ");
            string g = Console.ReadLine();
            var someTuple = CreateCortage(g);
            Console.Write("Вы хотите вывести кортеж целиком или выборочно:");
            Console.Write("\nЦеликом(1):");
            Console.Write("\nВыборочно(2):");
            int t = Convert.ToInt32(Console.ReadLine());
            switch (t)
            {
                case 1:
                    Console.WriteLine("\nЗначение int len = " + someTuple.Item1.ToString());
                    Console.WriteLine("Значение string s = " + someTuple.Item2);
                    Console.WriteLine("Значение char ch = " + someTuple.Item3);
                    Console.WriteLine("Значение  string s1 = " + someTuple.Item4);
                    Console.WriteLine("Значение ulong l1 = " + someTuple.Item5);
                    break;
                case 2:
                    Console.Write("Какие значения вы не хотите вывевести:(1-5)");
                    int t1 = Convert.ToInt32(Console.ReadLine());
                    switch (t1)
                    {
                        case 1:
                            Console.WriteLine("Значение string s = " + someTuple.Item2);
                            Console.WriteLine("Значение char ch = " + someTuple.Item3);
                            Console.WriteLine("Значение  string s1 = " + someTuple.Item4);
                            Console.WriteLine("Значение ulong l1 = " + someTuple.Item5);
                            break;
                        case 2:
                            Console.WriteLine("\nЗначение int len = " + someTuple.Item1.ToString());
                            Console.WriteLine("Значение char ch = " + someTuple.Item3);
                            Console.WriteLine("Значение  string s1 = " + someTuple.Item4);
                            Console.WriteLine("Значение ulong l1 = " + someTuple.Item5);
                            break;
                        case 3:
                            Console.WriteLine("\nЗначение int len = " + someTuple.Item1.ToString());
                            Console.WriteLine("Значение string s = " + someTuple.Item2);
                            Console.WriteLine("Значение  string s1 = " + someTuple.Item4);
                            Console.WriteLine("Значение ulong l1 = " + someTuple.Item5);
                            break;
                        case 4:
                            Console.WriteLine("\nЗначение int len = " + someTuple.Item1.ToString());
                            Console.WriteLine("Значение string s = " + someTuple.Item2);
                            Console.WriteLine("Значение char ch = " + someTuple.Item3);
                            Console.WriteLine("Значение ulong l1 = " + someTuple.Item5);
                            break;
                        case 5:
                            Console.WriteLine("\nЗначение int len = " + someTuple.Item1.ToString());
                            Console.WriteLine("Значение string s = " + someTuple.Item2);
                            Console.WriteLine("Значение char ch = " + someTuple.Item3);
                            Console.WriteLine("Значение  string s1 = " + someTuple.Item4);
                            break;
                    }
                    break;


            }
            //c
            //(int,int)kol1=(Ko:5,Ko1:10);
            //object V = kol1;
            //var K = (Ko1)V;

           
       
           
        




        }
    }
}
