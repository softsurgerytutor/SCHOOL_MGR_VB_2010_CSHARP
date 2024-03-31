﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Utils
{
    class StaticMethods{
        public static int CalculateDateDifferenceInYears(string date1, string date2){
            DateTime dt1 = DateTime.ParseExact(date1, "dd/MM/yyyy", null);
            DateTime dt2 = DateTime.ParseExact(date2, "dd/MM/yyyy", null);
            int yearsDiff = dt2.Year - dt1.Year;
            if (dt1.Month > dt2.Month || (dt1.Month == dt2.Month && dt1.Day > dt2.Day)){
                yearsDiff--;
            }
            return yearsDiff;
        }

        public static string GetTodayDate(){
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}