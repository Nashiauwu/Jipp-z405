using System;

namespace ConsoleApp1

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Podaj swoje imię:");

            var name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            int result = 5 + 9;

            int number = 7;

            float money = 7;

            string text = "siema";

            bool isLogged = true;

            char myChar = 'x';

            double price = 7.7;

            Console.WriteLine(result + " " + number + " " + money + " " + text + " " + isLogged + " " + myChar + " " + price);

            string myAge = "Age: ";

            int wifeAge = 18;

            string result1 = myAge + wifeAge;

            Console.WriteLine(result1);

            // takie wnioski ze nie musze sie bawic i string z intem sie ladnie dodaja

            bool isTrue = true;

            bool isFalse = false;

            bool isReallyTrue = true;

            bool and = isTrue && isFalse;

            bool or = isTrue | isReallyTrue;

            bool negative = !isFalse;

            Console.WriteLine(and + " " + or + " " + negative);

            int a = 5;

            int b = 12;

            int add = a + b;

            int sub = a - b;

            int div = a / b;

            int mul = a * b;

            int mod = a % b;

            Console.WriteLine(add + " " + sub + " " + div + " " + mul + " " + mod);


            string a1 = "ala ", b1 = "ma ", c1 = "kota ";

            string result2 = a1 + b1 + c1;

            Console.WriteLine(result2);

            //ladnie sie dodaje

        }

    }

}

