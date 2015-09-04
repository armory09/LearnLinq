using System;

namespace LearnLINQ.Delegate
{  

    public class Delegates
    {

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadeciaml: {0:X}", dec);
        }

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }

        public delegate void Print(int value);

        public static void Printnumber(int num)
        {
            Console.WriteLine("Number: {0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}
