using System;

namespace ConsoleApp1
{
    class Program
    {
        //instrukcje steruja i petle
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20;

            //zad1
            if (n1 > n2)
            {
                Console.WriteLine("n1 jest wieksze od n2");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("n2 jest wieksze od n1");
            }
            else
            {
                Console.WriteLine("n1 jest rowne n2");
            }
            //zad2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }

            int w = 0;
            while (w < 10)
            {
                Console.WriteLine("C#");
                w++;
            }
            //zad3
            int n = 10;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - parzysta");
                }
                else
                {
                    Console.WriteLine(i + " - nieparzysta");
                }
            }
            //zad4
            int n3 = 5;

            for (int i = 0; i <= n3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            int exam = 57;
            if (exam < 0 || exam > 100) { 
            Console.WriteLine("wartosc poza zakresem");
        }
            else if (exam <= 39){
                    Console.WriteLine("Ocena niedostateczna");
            }
            else if (exam <= 54)
            {
                Console.WriteLine("Ocena Dopuszczajaca");
            }
            else if (exam <= 69)
            {
                Console.WriteLine("Ocena Dostateczna");
            }
            else if (exam <= 84)
            {
                Console.WriteLine("Ocena Dobra");
            }
            else if (exam <= 98)
            {
                Console.WriteLine("Ocena Bardzo Dobra");
            }
            else if (exam <= 100)
            {
                Console.WriteLine("Ocena Celujaca");
            }












        }
    }
}