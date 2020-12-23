using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-7?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( WeekDayConverter.GetNameByDay(day));
            Console.Read();
        }
    }
}
