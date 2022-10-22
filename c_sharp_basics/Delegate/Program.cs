using System;
namespace Delegate
{
    class Delegate
    {
        static void Main()
        {
            var emps = new Employee[]
            {
                new Employee{Id=1,Name="Issam",Gender="m",TotalSales=234234 },
                new Employee{Id=2,Name="asem",Gender="m",TotalSales=245987765 },
                new Employee{Id=3,Name="ahmed",Gender="m",TotalSales=39034 },
                new Employee{Id=4,Name="ghareeb",Gender="m",TotalSales=36390 },
                new Employee{Id=5,Name="mohamed",Gender="m",TotalSales=2304 },
                new Employee{Id=6,Name="tarek",Gender="m",TotalSales=203424 },
                new Employee{Id=7,Name="abdo",Gender="m",TotalSales=2773234 },
                new Employee{Id=8,Name="ziad",Gender="m",TotalSales=2374 }
            };

            var report = new Report();
            report.ProssesEmployee(emps, "sales >= $60,000",isGreatereThanOrequal60000);

            //we can use anonymous delegate key word
            report.ProssesEmployee(emps, "sales >= $60,000",delegate (Employee e) { return e.TotalSales > 60000; });


            //we can use fat arrow
            report.ProssesEmployee(emps, "sales between30000And60000",  (Employee e)=>e.TotalSales >= 30000 && e.TotalSales<60000);

            report.ProssesEmployee(emps,"sales <30000",e => e.TotalSales < 30000) ;
                
        }
        static bool isGreatereThanOrequal60000(Employee e) => e.TotalSales > 60000;
        static bool isBetween30000And60000(Employee e) => e.TotalSales >= 30000 && e.TotalSales < 60000;
        static bool isLessThan30000(Employee e) => e.TotalSales <30000;
    }
}