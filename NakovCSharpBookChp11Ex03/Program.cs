using System;


namespace NakovCSharpBookChp11Ex03
{
    class DayOfTheWeek
    {
        static void Main(string[] args)
        {
        
           GetDayOfWeek();
           
        }

        public static void GetDayOfWeek()
        {
            var now = DateTime.Now;
            var day = System.DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine("Today is {0}, {1:d}", day, now);
        }
    }
}
