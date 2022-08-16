using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int x=int.Parse(Console.ReadLine());
            Sumdigits(x);

        }
        static void Sumdigits(int x)
        {
            int z=0;
            while(x>=1)
            {
                int y=x%10;
                z+=y;
                x=x/10;
            }
            Console.WriteLine("The sum is "+z);
        }
    }
}
