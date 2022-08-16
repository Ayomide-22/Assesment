using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of arrays");
            int length =int.Parse(Console.ReadLine());
            int length2= length*2;
            int[]arr1=new int[length];
            int[]arr2=new int[length];
            int[]arr3=new int[length2];
            int a=0;
            Console.WriteLine();
            for(int j=0;j<length;j++)
            {
                Console.WriteLine("Enter number in first array");
                arr1[j]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int j=0;j<length;j++)
            {
                Console.WriteLine("Enter number in second array ");
                arr2[j]=int.Parse(Console.ReadLine());
            }    
            for(a=0;a<length;a++)
            {
                arr3[a]=arr1[a];
            }
            for(int j=0;j<length;j++)
            {
                arr3[a]=arr2[j];
                a++;
            }           
            int asc=0;
            for(int i=0;i<arr3.Length;i++)
            {
               for(int j=i+1;j<arr3.Length;j++)
               {
                   if(arr3[i]>arr3[j])
                   {
                       asc=arr3[i];
                       arr3[i]=arr3[j];
                       arr3[j]=asc;
                   }
               }
            }  
            foreach(var item in arr3)
            {
                Console.Write(item+" ");
            }          
        }
    }
}
