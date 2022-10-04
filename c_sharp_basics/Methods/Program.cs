using System;
namespace app
{
    class app
    {
        static void Main()
        {
            demo d = new demo();
            //argument is the value that the parameter take
            //we should initilize the argument
            //we can use (out) to pass unintilized argument 
            int age;
            d.DoSomeThing2(out age);
            Console.WriteLine(age);
            var numstring = "123456e";
            int number;
            if(!int.TryParse(numstring, out number))
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine($"you provided a valid number{number}");
            }
            
            d.Promote(number);

            

            d.printEvens(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }); 
            //printEvents2 is static funcution so we call it from the class name
            demo.printEvens2(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }
    }
    public class demo
    {
        //method
        public  void DoSomeThing()
        {
            Console.WriteLine("do some thing");
            
        }
        //age in parammter
        // ref make the parameter by reference
        public void DoSomeThing2(out int age)
        {
            age = 12;
            age = age + 3;
        }

        public void Promote(double amount)
        {
            Console.WriteLine($"you've got a promotion of ${amount}");
        } 
        public void Promote(double amount,string trip)
        {
            Console.WriteLine($"you've got a promotion of ${amount} and a trip {trip}");
        }    
        public void Promote(double amount,string trip,string hotel)
        {
            Console.WriteLine($"you've got a promotion of ${amount} and a trip {trip} and {hotel}");
        }

        
        public void printEvens(int[] arr)
        {
            foreach(var item in arr)
            {
                if (IsEven(item)) Console.WriteLine(item);
            }
            //local method
            bool IsEven(int number) => number % 2 == 0;

        }
        public static void printEvens2(int[] arr)
        {
            foreach(var item in arr)
            {
                if (IsEven(item)) Console.WriteLine(item);
            }
            //local method
            bool IsEven(int number) => number % 2 == 0;
            //in static funcution we have to use static methods only
            //or local methods
            Console.WriteLine(IsEven2(6));
            
        }

        public static bool  IsEven2(int number) => number % 2 == 0;



    }
}

