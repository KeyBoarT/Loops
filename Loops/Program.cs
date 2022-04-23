using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops
            // While, Do-While, For, Foreach


            //While
            int number1 = 0;
            while (true)
            {
                Console.Write("0'dan büyük bir sayı giriniz : ");
                number1 = int.Parse(Console.ReadLine());
                if (number1 <= 0)
                {
                    Console.WriteLine("Yanlış sayı girdiniz !");
                    continue;
                }
                else { break; }
            }

            //Do-While
            int number2 = 6;
            int number3;
            do
            {
                Console.WriteLine("Sayı 2 = " + number2);
                Console.Write("Sayı 2 'den büyük bir sayı giriniz  : ");
                number3 = int.Parse(Console.ReadLine());
            } while (number2 > number3);

            //For
            string Text1 = "Text";
            for (int i = 0; i < Text1.Length; i++)
            {
                Console.WriteLine(i + " = " + Text1[i]);
            }

            //Foreach
            Console.WriteLine("Metninizi giriniz : ");
            string Text2 = Console.ReadLine();
            foreach(char character in Text2)
            {
                Console.WriteLine(character);
            }

            Console.ReadKey();
        }
    }
}
