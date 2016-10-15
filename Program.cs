using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffOfTwoDates
{
    class Program
    {
        static void Main(string[] args)

        {
            DateTime myValue = DateTime.Now;    
            Console.WriteLine("Please Enter the First Date ");
            string date1 = Console.ReadLine();
            DateTime dt1 = Convert.ToDateTime(date1);
            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt1.Year, dt1.Month, dt1.Day);
            Console.WriteLine("Please Enter the Second Date ");
            string date2 = Console.ReadLine();
            DateTime dt2 = Convert.ToDateTime(date2);
            
            //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt2.Year, dt2.Month, dt2.Day);
           // TimeSpan ts = DateTime.Now.Subtract(dt1);
            //Console.WriteLine(ts.TotalDays.ToString());

           // DateTime myValue1 = DateTime.Now;
            TimeSpan ts1 = DateTime.Now.Subtract(dt1);
            
            Console.WriteLine(ts1.Days.ToString());
            Console.ReadLine();
            



        }
    }
}
