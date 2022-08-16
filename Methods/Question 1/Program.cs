using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word=Console.ReadLine();
            Getmid(word);

        }
        static void Getmid(string word)
        {
            int x=word.Length;
            int z=0;
            double y=x;
            if(y%2==1)
            {
                y=(y/2)+0.5;
                z=(int)y;
            }
            else if(y%2==0)
            {
                y=y/2;
                z=(int)y;
            }
            if(x%2==0)
            {
                Console.WriteLine(word[z-1]+" "+word[z]);
            }
            else if(x%2==1)
            {
                Console.WriteLine(word[z-1]);
            }
        }
    }
}
