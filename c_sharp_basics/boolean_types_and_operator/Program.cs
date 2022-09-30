using System;
namespace lesson;
class programe
{
    static void Main()
    {
        //var x=10;
        //var y = 10;
        ////Console.WriteLine(x == y);
        //var z = x == y;
        //Console.WriteLine(z);


        //var total = 1000;
        //var VIPThreshold = 900;
        //bool isVIP = total >= VIPThreshold;
        //Console.WriteLine(isVIP);

        //isVIP = !true;
        //Console.WriteLine(isVIP);

        //Console.WriteLine(true||true);

        ////xor false if the two operands is false or true
        //Console.WriteLine(true^true);//false
        //Console.WriteLine(false^false);//false

        /* //////////////////////////////////////////// */

        // || && short circut
        // |   & long circut

        // in this case when the conpiler find that the first operand is true the value will be true and he won't call to the funcution
        bool value1 = true || check();
        
        // in this case the compiler will call the funcution even if the first operand is true
        bool value2= true | check();


        /*  /////////////////////////////////////// */


        // ==    reference type
        var x = 1;
        var y = 1;

        //compare the values (value type);
        var z = x == y;
        Console.WriteLine(z);//true

        var m = "hello";
        var w = "hello";

        // compare the references (reference type) 
        var t=m==w;
        Console.WriteLine(t);//true



        /* //////////////////////////////////// */
        // ternary operator

        var total = 900;
        var VipThresHold = 1000;
        //if (total >= vipthreshod)
        //isvip=true
        //else isvip =false
        var Isvip = total >= VipThresHold ? true : false;
        var DisCount = total >= VipThresHold ? 0.05m : 0.0m;
        Console.WriteLine(DisCount);

        Console.ReadKey();
    }

    static bool check()
    {
        Console.WriteLine("ckecking");
        return true;
    }
}
