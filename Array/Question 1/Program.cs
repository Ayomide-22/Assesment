using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of first array");
            int length1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of second array");
            int length2=int.Parse(Console.ReadLine());
            int count =0;
            int[] arr1=new int[length1];
            int[] arr2=new int[length2];
            for(int j=0;j<length1;j++)
            {
                Console.WriteLine("Enter a number in the first array");
                arr1[j]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int j=0;j<length2;j++)
            {
                Console.WriteLine("Enter a number in the second array");
                arr2[j]=int.Parse(Console.ReadLine());
            }         
            for(int j=0;j<length1;j++)
            {
                count=0;
                for(int k=0;k<length2;k++)
                {
                    if(arr1[j]==arr2[k])
                    {
                        count++;
                    }
                }
                Console.WriteLine(arr1[j]+" occured "+count+" times");
            }      


        }
    }
}
