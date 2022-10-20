using System;

namespace Delegate
{
    public  class Report
    {

        public delegate bool illegibleSales(Employee e);
        public void ProssesEmployee(Employee[] employees,string title, illegibleSales IsIllegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------");

            foreach (var E in employees)
            {
                if (IsIllegible(E))
                {
                    Console.WriteLine($"{E.Id} | {E.Name} | {E.Gender} | {E.TotalSales} ");
                }
            }
            Console.WriteLine("\n\n");
        }

        //public void processEmployeeWith60000PlusSales(Employee[] employees)
        //{
        //    Console.WriteLine("Employee with $60,000 sales");
        //    Console.WriteLine("-----------------------------");

        //    foreach(var E in employees)
        //    {
        //        if (E.TotalSales >= 60000)
        //        {
        //            Console.WriteLine($"{E.Id} | {E.Name} | {E.Gender} | {E.TotalSales} ");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}   
        //public void processEmployeeWithSalesBetween30000And59000(Employee[] employees)
        //{
        //    Console.WriteLine("Employee with Sales between $30,000 and $59,000sales");
        //    Console.WriteLine("-----------------------------");

        //    foreach(var E in employees)
        //    {
        //        if (E.TotalSales >= 30000&&E.TotalSales<=60000)
        //        {
        //            Console.WriteLine($"{E.Id} | {E.Name} | {E.Gender} | {E.TotalSales} ");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}
                
        //public void processEmployeeWithSaleLessThan30000(Employee[] employees)
        //{
        //    Console.WriteLine("Employee with Sales Less than $30000");
        //    Console.WriteLine("-----------------------------");

        //    foreach(var E in employees)
        //    {
        //        if (E.TotalSales < 30000)
        //        {
        //            Console.WriteLine($"{E.Id} | {E.Name} | {E.Gender} | {E.TotalSales} ");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}



    }
}
