using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_satatement_Sunday
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter the number of The day of the week ");
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(DaysOfTheWeek(num));

            Console.ReadLine();


        }
        static string  DaysOfTheWeek(int DayNumber) {

            string DayName;

            switch (DayNumber)
            {
                case 1:
                    DayName = "Monday";
                    break;

                case 2:
                    DayName = "TuesDay";
                    break;

                case 3:
                    DayName = "wednesday";
                    break;

                case 4:
                    DayName = "Thursday";
                    break;

                case 5:
                    DayName = "Friday";
                    break;

                case 6:
                    DayName = "Saturday";
                    break;

                case 7:
                    DayName = "Sunday";
                    break;

                default:
                    DayName = "not the Day of the Week";
                    break;

            }

            return DayName;
        }
    }
}
