using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x=int.Parse(Console.ReadLine());
            Palindrome(x);
        }
        
        static void Palindrome(int x)
        {
            int y=x;
            int reverse=0;
            while(x>=1)
            {
                int z=x%10;
                reverse=(reverse*10)+z;
                x=x/10;
            }
            if(y==reverse)
            {
                Console.WriteLine(y+" is a palindrome");
            }
            else
            {
                Console.WriteLine(y+" is not a palindrome");
            }
        }
    }
}
