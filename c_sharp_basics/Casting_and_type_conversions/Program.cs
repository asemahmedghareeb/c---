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

            // Console.Write(i);
            
            //boxing , unboxing
            //boxing is convertion from datatype value to data type reference
            
            int z=10;//value type
            object obj;//reference type
            obj=z;//convertion done implicitly (boxing )=>value type  to reference type
            
            int v=(int)obj;//convertion done explicitly (unboxing) => refernce type to value type

            //string to numbers

            string val="9999";
            // int number=int.Parse(val);


            //out int number means if we can convert put the value of convertion in number variable
            if(int.TryParse(val,out int number)){

                Console.WriteLine(number);

            }else{
                Console.WriteLine("invailed number or doesn't fit integer");
            }
            

            // Convert class 
            //it's do the same like parse and try parse but slightly less performnce 
            var h= Convert.ToInt32(val);
            Console.WriteLine(h);

            double uu =Convert.ToDouble(val);
            
        }
    }
}