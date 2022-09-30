using System;
using System.Security.Cryptography;

namespace Expressions;
class Expressions
{
    static void Main(string[] args)
    {
        //         Lookup.Mothod call
        var amount =Math.Cos(30);
        //Console.WriteLine(amount);

        var x = 2;
        var y = 5;
        Console.WriteLine($" x + y = {x+y}");
        // we can't use null with var datatype var s = null;
        string str = null;

        //null coalescing (null checking)this mean if str equal null assign "asem" to it
        str = str ?? "asem";

        str=str ?? "ahmed";


        // Mull reference Execption
        string s1 = null;//string s1 ="" not equal var s2 = s1.ToUpper();
        //this mean if s1 not null call the funcution other wise don't call it
        string s2 =s1?.ToUpper();
        // this do the same as the last one
        var s3=s1 is null ? null:s1.ToUpper();
        Console.ReadKey();
    }
}