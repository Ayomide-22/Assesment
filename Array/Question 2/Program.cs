using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int length =int.Parse(Console.ReadLine());
            int[]arr=new int[length];
            Console.WriteLine();
            for(int j=0;j<length;j++)
            {
                Console.WriteLine("Enter number");
                arr[j]=int.Parse(Console.ReadLine());
            }
            int neutral=0;
            int smallest=0;
            int biggest=0;
            int sindex=0;
            int bindex=0;
            for(int j=0;j<length;j++)
            {
                if(j==0)
                {
                    biggest=arr[0];
                    smallest=arr[0];
                    bindex=0;
                    sindex=0;
                }
                if(arr[j]>biggest)
                {
                    biggest=arr[j];
                    bindex=j;
                }
                if(arr[j]<smallest)
                {
                    smallest=arr[j];
                    sindex=j;
                }
            }
            if(sindex>bindex)
            {
                neutral=bindex;
                bindex=sindex;
                sindex=neutral;
            }
            for(int j=sindex;j<=bindex;j++)
            {
                Console.Write(arr[j]+" ");
            }
        }
    }
}
