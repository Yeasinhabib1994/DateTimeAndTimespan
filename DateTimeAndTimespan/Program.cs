using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndTimespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2018, 10, 8);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration: " + duration);

            var timespan = new TimeSpan(1, 2, 3);
            Console.WriteLine("minutes: " + timespan.Minutes);
            Console.WriteLine("total minutes: " + timespan.TotalMinutes);
            Console.WriteLine("timespan addition: " + timespan.Add(TimeSpan.FromMinutes(-2)));
            Console.WriteLine("tostring: " + timespan.ToString());
            Console.WriteLine("parse: " + TimeSpan.Parse("01:02:03"));
        } 
    }
}
