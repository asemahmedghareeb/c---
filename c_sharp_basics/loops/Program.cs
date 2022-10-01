using System;
using System.Collections.Specialized;
using System.Net.Http.Headers;

namespace loops
{
    class loops
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (counter<10)
            {
                Console.Write(counter +" ");
                counter++;
            }

            Console.WriteLine(" ");
            counter = 0;
            do
            {
                Console.Write(counter + " ");
                ++counter;

            } while (counter < 10);

            Console.WriteLine(" ");
            //fibonacci
            for(int i = 0,prev=0, current=1; i < 10; i++)
            {
                Console.Write(prev + " ");
                int newfib = prev + current;
                prev = current;
                current = newfib;
            }

            Console.WriteLine("\n");

            foreach (var c in "full stack developer course")
                Console.Write(c + " ");

            Console.WriteLine("\n");
            var arr=new int[] {1,2,3,4,5,6,7,8,9,10};
            foreach (var i in arr)
                Console.Write(i + " ");

            Console.WriteLine("\n");
            //got to 
            var v = 0;
            start:
            if(v < 5)
            {
                v++;
                Console.Write(v + " ");
                goto start;
            }

            Console.WriteLine("\n");
            var input = .44m;
            var result = Aspercent(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static decimal Aspercent(decimal amount)
        {
            return amount * 100;
        }
    }



}