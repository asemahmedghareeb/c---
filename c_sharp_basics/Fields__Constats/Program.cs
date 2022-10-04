using Fields__Constats;
using System;
namespace app
{
    class app
    {
        static void Main(string[] args)
        {   //object (instants)syntax 
            //declaration type <object name> 
            // assignment objectName -new type()
            // initilization

            //class is reference type 

            //objects stored in stack but the value is in heap
            employee e1 = new employee();
            Console.Write("tax : ");
            employee.TAX = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("first name : ");
            e1.FName =Console.ReadLine();

            Console.Write("last name : ");
            e1.LName=Console.ReadLine();


            Console.Write("Wage : ");
            e1.wage=Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged hours : ");
            e1.LoggedHours=Convert.ToDouble(Console.ReadLine());


            employee[] emps = new employee[1];
            emps[0] = e1;
            foreach(var emp in emps)
            {
                Console.WriteLine(emp.printslipt());
            }
            Console.Read();
        }
    }
}