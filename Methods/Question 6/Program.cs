using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x=int.Parse(Console.ReadLine());
            Checkeven(x);
        }
        static void Checkeven(int x)
        {
            bool check=true;
            while(x>=1)
            {
                int y=x%10;
                if(y%2==0)
                {
                    check=true;
                }
                else if(y%2!=0)
                {
                    check=false;
                    break;
                }
                x=x/10;
            }
            if(!check)
            {
                Console.WriteLine("False");
            }
            else if(check)
            {
                Console.WriteLine("True");
            }

        }
    }
}
