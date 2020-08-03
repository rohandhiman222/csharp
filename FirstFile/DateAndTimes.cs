using System;

namespace FirstFile
{
    public class DateAndTimes
    {
        static void MyDate()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            
            
                // time span
                
           var timeSapn = new TimeSpan(1,2, 3);
           var timespan1 = new TimeSpan(1, 0, 0);
           TimeSpan.FromHours(1);

           var start = DateTime.Now;
           var end = DateTime.Now.AddMinutes(2);
           var duration = end - start;
           Console.WriteLine(duration);
           
           
           // Properties
           Console.WriteLine(timeSapn.Minutes);
           Console.WriteLine(timeSapn.TotalMinutes);
           
           // Add time stamp is mutable if created you can't change
           Console.WriteLine("Add examples" + timeSapn.Add(TimeSpan.FromMinutes(8)));
           Console.WriteLine("Add examples" + timeSapn.Subtract(TimeSpan.FromMinutes(2)));
           
           // ToString
           Console.WriteLine("ToString" + timeSapn.ToString());
           
           // Parse
           Console.WriteLine("Parse" + TimeSpan.Parse("01:02:03"));
           
           
           
        }
    }
}