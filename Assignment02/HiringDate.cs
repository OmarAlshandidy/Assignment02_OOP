using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment02
{
    internal class HiringDate
    {
        #region Atteibute 
        private int day;
        private int month;
        private int year;
        #endregion
        #region Constructor 
        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion

        #region Properaty 
        public int Day
        {
            get { return day; }
            set
            {
                day = (value >= 1 && value <= 30) ? value : 1;
            }

        }
        public int Month
        {
            get { return month; }
            set
            {
                month = (value >= 1 && value <= 12) ? value : 1;

            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                year = (value >= 2000 && value <= DateTime.Now.Year) ? value : DateTime.Now.Year;
            }
        }

        #endregion
        public override string ToString()
        {

            return $"{Day}/{Month}/{Year}";
        }



    }
}   


