using System;
using System.Collections.Generic;

namespace hello_console
{

    public struct DateRange{

        public DateRange(DateTime start, DateTime end){
            Start =start;
            End = end;
        }
        public  DateTime Start{get; }

        public DateTime End{get; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            DateTime end = new DateTime(2020, 08, 04);
            DateTime start = new DateTime(2020, 07, 15);            

            DateTime[] holidays = {
            new DateTime(2020, 07, 18),
            new DateTime(2020, 07, 25),
            new DateTime(2020, 07, 26),
            new DateTime(2020, 08, 01),
            new DateTime(2020, 08, 02)
            };

            DateRange range =new DateRange(start, end);

            Console.WriteLine("Working days: " + CountWorkingDays(start,end, holidays));
            Console.WriteLine("Working days(with struct using): " + CountWorkingDaysWithStruct(range, holidays));

        }


        public static int CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays)
        {
            int daysCount = 0;

            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {

                dt.
                int search =Array.BinarySearch(holidays, dt);
                Console.WriteLine(dt.ToString());
                if(search <= 0){
                    daysCount+=1;
                }
            }
            return daysCount;
        }

        public static int CountWorkingDaysWithStruct(DateRange range, DateTime[] holidays)
        {
            return CountWorkingDays(range.Start, range.End, holidays);
        }
    }  
} 
