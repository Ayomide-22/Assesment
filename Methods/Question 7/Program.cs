using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string number =Console.ReadLine();
            Reverse(number);
        }
        static void Reverse(string number)
        {
            for(int x=number.Length-1;x>=0;x--)
            {
                Console.Write(number[x]);
            }
        }
    }
}
