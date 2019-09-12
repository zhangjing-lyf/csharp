using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            if(a<1)
            {
                Console.WriteLine("this is my first line");
            }
            else{
                Console.WriteLine("this is my second line");
                
            }
            int i;
            for(i=0;i<5;i++)
            {
                Console.WriteLine("this is {0}th run",i);

            }
        }
    }
}
