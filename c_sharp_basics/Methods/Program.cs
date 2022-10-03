using System;
namespace app
{
    class app
    {
        static void Main()
        {
            demo d = new demo();
            var val =d.DoSomeThing2();
            Console.WriteLine(val); 
        }
    }
    public class demo
    {
        //method
        public  void DoSomeThing()
        {
            Console.WriteLine("do some thing");
            
        }
        public int DoSomeThing2()
        {

            return 10;
        }
    }
}

