using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


    public class DateModifierClass
    {
        public static int Difference(string firstDate, string secondDate)
        {
            DateTime firstDateTime = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDateTime = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        
        return Math.Abs((firstDateTime - secondDateTime).Days);
        }
    }

