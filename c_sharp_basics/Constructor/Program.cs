


class program
{
    static void Main(string[] args)
    {
        date d1 = new date(12, 2000);
        Console.WriteLine(d1.GetDate());
        //    Employee e1 = new Employee();
        //e1.FName = "asem";
        //e1.Lname = "ahmed";
        //e1.Id = 1000;


        ////----------->> object  initilizer
        //Employee e2 = new Employee
        //{
        //    Id = 100,
        //    FName = "asem",
        //    Lname = "ahmed"         
        //};        
        //Employee e3 = new Employee(1000)
        //{

        //    FName = "asem",
        //    Lname = "ahmed"         
        //};

        Employee e4 = Employee.create(2000, "asem", "ahmed");
        Console.WriteLine(e4.DisplayName());
    }
    }

    public class date
    {   //readonly is keyword that stop the ability of changing the value except in the constructor
        private static readonly int[] daysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] daysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        //naming best practice for private is (dayMonth)or(_dayMonth
        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;
        public date(int day, int month, int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeap ? daysToMonth366 : daysToMonth365;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }

        }
        //constructor overloading
        public date(int year) : this(01, 01, year)
        {

        }
        public date(int month, int year) : this(01, month, year)
        {

        }

        //public void Set_value(int Day ,int Month ,int Year)
        //{
        //    this.day = Day;
        //    this.month = Month;
        //    this.year = Year;
        //}
        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
        }
    }


    public class Employee
    {
        private Employee() { }
        private Employee(int id, string fname, string lname)
        {
            Id = id;
            FName = fname;
            Lname = lname;
       
        }
        //private constructor
        //factory funcution (only through this funcution we can make objects and must be static)
        
        public static Employee create(int id, string fname, string lname)
        {
            //return  object  of employee
            return new Employee(id, fname, lname);
        }


        public Employee(int id)
        {
            Id = id;
        }
        private int Id;
        private string FName;
        private string Lname;

        public string DisplayName()
        {
            return $"id : {Id} name :{FName} {Lname}\n";
        }
    }



