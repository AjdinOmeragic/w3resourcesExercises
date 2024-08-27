using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ascii value of 1 is: " + ASCI('1'));
            Console.WriteLine("Ascii value of A is: " + ASCI('A'));
            Console.WriteLine("Ascii value of a is: " + ASCI('a'));
            Console.WriteLine("Ascii value of # is: " + ASCI('#'));
        }
        public static int ASCI(char ch)
        {
            return (int)ch;
        }
    }
}