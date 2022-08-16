using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the scores for Math, English and French accordingly");
            int[] arr=new int[3];
            for(int j=0;j<3;j++)
            {
                Console.WriteLine("Enter score");
                arr[j]=int.Parse(Console.ReadLine());
            }
            for(int j=0;j<3;j++)
            {
                if(arr[j]<50)
                {
                    arr[j]=arr[j]+10;
                }
                else if(arr[j]<60)
                {
                    arr[j]=arr[j]+2;
                }
                else if(arr[j]>70)
                {
                    arr[j]=arr[j]-5;
                }
                else
                {
                    arr[j]=arr[j]+4;
                }
            }
            Console.WriteLine("Math-"+arr[0]+" English-"+arr[1]+" French-"+arr[2]);
        }
    }
}
