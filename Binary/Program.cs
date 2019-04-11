using System;
namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToBinary();
        }
        static void ConvertToBinary()
        {
            start: Console.Write("Enter your number here : ");
            long i = long.Parse(Console.ReadLine()); 
            Console.WriteLine($"Binary conversion is : {Binary(i)} \n");
            goto start;
        }
        static string Binary(long j)
        {
            string binary = " ";
            while (j > 0)
            {
                j = j / 2; binary = j % 2 + binary;
            }
            return binary;
        }
    }
}