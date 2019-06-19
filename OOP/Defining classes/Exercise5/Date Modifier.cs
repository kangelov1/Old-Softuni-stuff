using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class DateModifier
    {
        private int differenceInDays;

        private string date1;
        private string date2;
        
        public DateModifier(string date1,string date2)
        {
            this.date1 = date1;
            this.date2 = date2;
        }
        public int CalculateDifference()
        {
            var string1 = this.date1.Split().Select(int.Parse).ToArray();
            var string2 = this.date2.Split().Select(int.Parse).ToArray();

            DateTime date1 = new DateTime(string1[0],string1[1],string1[2]);
            DateTime date2 = new DateTime(string2[0], string2[1], string2[2]);

            if(date1.CompareTo(date2) < 0)
            {
                var temp = date1;
                date1 = date2;
                date2 = temp;
            }

            var difference = new TimeSpan();
            difference = date1 - date2;
            differenceInDays = difference.Days;
            return differenceInDays;
        }
    }
}
