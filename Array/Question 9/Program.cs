using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows of the array");
            int r=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of colums of the array");
            int c=int.Parse(Console.ReadLine());  
            int[,] arr1=new int[r,c];  

            for(int row=0;row<r;row++)
            {
                for(int col=0;col<c;col++)
                {
                    Console.WriteLine("Enter value in first matrix for row "+row+" column "+col);
                    arr1[row,col]=int.Parse(Console.ReadLine());
                }
            }  

            int[,] arr2=new int[r,c];  
            for(int row=0;row<r;row++)
            {
                for(int col=0;col<c;col++)
                {
                    Console.WriteLine("Enter value in second matrix for row "+row+" column "+col);
                    arr2[row,col]=int.Parse(Console.ReadLine());
                }
            } 
            int[,] arr3=new int[r,c];  
            for(int row=0;row<r;row++)
            {
                for(int col=0;col<c;col++)
                {
                    arr3[row,col]=arr1[row,col]*arr2[row,col];
                }
            }    
            for(int row=0;row<r;row++)
            {
                for(int col=0;col<c;col++)
                {
                    Console.Write(arr3[row,col]+" ");
                }
                Console.WriteLine();
            }                
        }
    }
}
