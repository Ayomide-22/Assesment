using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows and columns of the array");
            int r=int.Parse(Console.ReadLine());
            int[,] arr=new int[r,r];  

            for(int row=0;row<r;row++)
            {
                for(int col=0;col<r;col++)
                {
                    Console.WriteLine("Enter value for row "+row+" column "+col);
                    arr[row,col]=int.Parse(Console.ReadLine());
                }
            }

            int x=0;
            for(int row=0;row<r;row++)
            {
                for(int col=row;col<=row;col++)
                {
                    x+=arr[row,col];
                }
            }
            Console.WriteLine("For the matrix:");
            for(int row=0;row<r;row++)
            {
                for(int col=0;col<r;col++)
                {
                    Console.Write(arr[row,col]+" ");
                }
                Console.WriteLine();
            }   
            Console.WriteLine("The sum of the diagonal is "+x);         
        }
    }
}
