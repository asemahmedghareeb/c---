


    class program
    {
        static void Main(string[] args)
        {
            date d1 = new date(29,02,2020);
            Console.WriteLine(d1.GetDate());
            
        }
    }

    public class date
    {   //readonly is keyword that stop the ability of changing the value except in the constructor
        private static readonly int[] daysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] daysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
                
        //naming best practice for private is (dayMonth)or(_dayMonth
        private readonly int day=01;
        private readonly int month=01;
        private readonly int year = 01;
        public  date(int day,int month,int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0||year%400==0); 
            if(year>=1 && year <=9999 && month >= 1 && month <= 12)
            {
                int[] days= isLeap ? daysToMonth366 : daysToMonth365;
                if(day>=1 && day <= days[month])
                {   
                    this.day = day;
                    this.month = month;
                    this.year  = year;
                }
            }
       
        }
        //constructor overloading
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


