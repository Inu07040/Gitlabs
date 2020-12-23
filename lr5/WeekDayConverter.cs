using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lr5
{
    class WeekDayConverter
    {
        public static string GetNameByDay(int dayNumber)
        {
            /*
            switch (dayNumber)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return string.Empty;
            }
            */

            Hashtable week = new Hashtable();
            week[1] = "Понедельник";
            week[2] = "Вторник";
            week[3] = "Среда";
            week[4] = "Четверг";
            week[5] = "Пятница";
            week[6] = "Суббота";
            week[7] = "Воскресенье";
            string result = week[dayNumber] as string;
            if (result == null)
                throw new ArgumentException("посмотри двумя строчками выше. тебе сказали 1-7");
            else return result;
        }
    }
}
