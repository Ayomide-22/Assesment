using System;

namespace Question_8
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
            int asc=0;
            for(int i=0;i<arr.Length;i++)
            {
               for(int j=i+1;j<arr.Length;j++)
               {
                   if(arr[i]>arr[j])
                   {
                       asc=arr[i];
                       arr[i]=arr[j];
                       arr[j]=asc;
                   }
               }
            }
            Console.WriteLine(arr[length-2]+" is the second largest");

        }
    }
}
