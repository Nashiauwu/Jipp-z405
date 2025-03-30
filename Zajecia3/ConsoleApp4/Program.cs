using System;
using System.Xml.Linq;

namespace ConsoleApp4;


    class Program

{

    static void Main(string[] args)

    {

        //zad1
        string[] colors = ["niebieski","czarny","czerwony","zielony"];
        Console.WriteLine("Mój pierwszy color to: " + colors[0]);
        Console.WriteLine("Mój ostatni color to: " + colors[3]);


        //zad2
        int[] liczby = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        for (int i = 0; i < 10; i++)
        {

            Console.WriteLine("Liczba: " + liczby[i]);

        }
            foreach (int element in liczby) {
                Console.WriteLine("Liczba: " +  element);

            }

        int n = 0;
            while (n < liczby[9])
        {
            Console.WriteLine("Liczba: " + liczby[n]);
                n++;
        }


        //zad3
        List<string> fruits = ["Pomidor", "Jabłko", "Marchewka", "Pomarańcz", "Winogrono"];

        foreach (string element in fruits)
        {
            Console.Write(element +", ");
        }

        fruits.Remove("Pomidor");
        fruits.RemoveAt(3);

        Console.WriteLine();
        

        foreach (string element in fruits)
        {
            Console.Write(element + ", ");
        }
    }
    }


