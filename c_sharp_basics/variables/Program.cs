using System;
namespace programe;
class variables
{
    static void Main(string[] args)
    {
        //intger is value type in stack
        int num = 1;
        //string is reference type (the identifier in stack but the value is in the heap
        string s1 = "asem";
        string s2 = "ahmed";
        //strinig concatenation
        string str = s1 + " " + s2;
        Console.WriteLine(str);
        //string interpolation
        string s4 = $"{s1} {s2}";
        Console.WriteLine(s4);

        Console.WriteLine($"int: [{int.MinValue}] | {int.MaxValue}]");


        //float
        var f = 0f;
        //double
        var d = 0d;
        //decimal
        var m = 0m;
        //unsigned integer
        var u = 0u;
        //long
        var l = 0l;
        //undigned long
        var ul = 0ul;

        int million = 1_000_000;
        Console.WriteLine(million);

        var result = (200 / 3.0);

        //after we assigned the var to a type we can't change is anymore
        // for example we can't do this result = "asem";
        Console.WriteLine(result);


        // in dynamic we can assign is to diffrent data types
        //is will resolve in run time
        dynamic x = 9;
        x = "abc";
        x = 10m;

        char letter = 'A';
        Console.WriteLine((int)letter);

        Console.WriteLine(ulong.MaxValue);

         






    }
}
