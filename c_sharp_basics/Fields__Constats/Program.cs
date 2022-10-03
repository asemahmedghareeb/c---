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
                var salary = emp.wage * emp.LoggedHours;
                var netsalary = salary- (salary* employee.TAX);

                var taxamount = salary * employee.TAX;
                Console.WriteLine($"\nfirst name : {emp.FName} ");
                Console.WriteLine($"last name : {emp.LName} ");
                Console.WriteLine($"wage : {emp.wage} ");
                Console.WriteLine($"logged hours : {emp.LoggedHours} ");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"salary : {salary}$");
                Console.WriteLine($"Dejuctable tax ({employee.TAX * 100}%)tax amount : {taxamount}");
                Console.WriteLine($"net salary : {netsalary}\n");
            }
            Console.Read();
        }
    }
}