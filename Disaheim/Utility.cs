using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Book)
            {
                Book book = (Book)merchandise;
                return book.Price;
            }
            else if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;
                double value = 0.0;
                switch (amulet.Quality)
                {
                    case Level.low:
                        value = 12.5;
                        break;
                    case Level.medium:
                        value = 20.0;
                        break;
                    case Level.high:
                        value = 27.5;
                        break;
                }
                return value;
            }
            return 0;
        }

         





    // GetValueOfBook method
    public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        //GetValueOfAmulet method

        public double GetValueOfAmulet(Amulet amulet)
        {
            double price = 0;

            if (amulet.Quality == Level.low)
            {
                price = 12.5;
            }

            else if (amulet.Quality == Level.medium)
            {
                price = 20.0;
            }

            else if (amulet.Quality == Level.high)
            {
                price = 27.5;
            }

            return price;
        }


        //Get Value of Course method
        public double GetValueOfCourse(Course course)
        {
            double hours = course.DurationInMinutes / 60;
            double remainingMinutes = course.DurationInMinutes % 60;
            if (remainingMinutes > 0)
            {
                hours++;
            }
            double pricePerHour = 875;
            double price = pricePerHour * hours;
            return price;
        }


        //    //Get Value of Course method

        //    public double GetValueOfCourse(Course course)
        //{
        //    double price = 0;
        //    int minutes = course.DurationInMinutes;


        //    if (minutes == 0)
        //    {
        //        price = 0;
        //    }

        //    else if (minutes >= 1 && minutes <= 60)
        //    {
        //        price = 875;
        //    }


        //    else if (minutes >= 61 && minutes <= 120)
        //    {
        //        price = 875 * 2;
        //    }


        //    else if (minutes >= 121 && minutes <= 240)
        //    {
        //        price = 875 * 3;
        //    }


        //    return price;




    }
}
