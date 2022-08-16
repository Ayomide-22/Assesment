using System;

namespace Question_5
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
            int count1=1;
            int count2=1;
            int consec=0;
            for(int j=0;j<length-1;j++)
            {
                if(arr[j]==arr[j+1])
                {
                    count2++;
                }
                else{count2=1;}
                if(count2>count1)
                {
                    count1=count2;
                    consec=arr[j];
                }
            }
            for(int j=1;j<=count1;j++)
            {
                Console.Write(consec+" ");
            }
        }
    }
}
