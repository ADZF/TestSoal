using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TestBNI
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;
            do
            {
                int pilih;
                Console.WriteLine();
                Menu();
                pilih = int.Parse(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        Console.Clear();
                        ChangeString();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        get_data();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Inputan Salah, ULANGI.");
                        Console.WriteLine("Tekan ENTER");
                        Console.Clear();
                        break;
                }
            } while (exit != 100);
        }

        public static void ChangeString()
        {
            string numbers = "123456789";
            int n = 6;

            for (int i = 1; i <= n; i++)
            {

                /*Console.WriteLine(numbers.Replace(numbers[i], '*'));
                Console.WriteLine();*/
                string output = Regex.Replace(numbers, $"[{numbers[i]}|{numbers[i+1]}]", "*");
                Console.WriteLine(output);
            }
        }

        public static void get_data()
        {

        }

        public static void Menu()
        {
            Console.WriteLine("==Test BNI==");
            Console.WriteLine("1. Soal Nomor 1");
            Console.WriteLine("2. Soal Nomor 2");
            Console.WriteLine("3. Exit");
            Console.Write("Input : ");
        }

    }
}
