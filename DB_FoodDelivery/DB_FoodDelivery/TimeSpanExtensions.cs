using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_FoodDelivery
{
    static class TimeSpanExtensions

    {

        static public bool IsBetween(this TimeSpan time,

                                    TimeSpan startTime, TimeSpan endTime)

        {

            if (endTime == startTime)

            {

                return true;

            }




            if (endTime < startTime)

            {

                return time <= endTime ||

                    time >= startTime;

            }




            return time >= startTime &&

                time <= endTime;

        }

    }
}
