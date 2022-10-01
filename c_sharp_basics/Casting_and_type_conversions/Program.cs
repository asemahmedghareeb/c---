using System;
namespace casting
{
    class casting
    {
        static void Main(string[] args)
        {
            Int16 s;// == short
            int  x;//== int32 x;
            Int64 l;//long
            short y;
            ushort unsigned_short;//==uint16
            ulong d;//== uint64
            
            var num=10;
            string str=num.ToString();
            int numberint=10;
            long numberlong=10;
            numberlong=numberint;
            //dotnet doesn't convert long to int automatically

            //numberint=numberlong;


            //explicit casting
            if(numberlong<=int.MaxValue){
                numberint=(int)numberlong;
            }
            
            double t=123.123;
            int i=(int)t;
            Console.Write(i);
            
            
            Console.ReadKey();
        }
    }
}