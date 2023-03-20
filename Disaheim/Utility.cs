using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
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
            double price = 0;          
            int minutes = course.DurationInMinutes;


            if (minutes == 0)
            {
                price = 0;
            }

            else if (minutes >= 1 && minutes <= 60)
            {
                price = 875;
            }


            else if (minutes >= 61 && minutes <= 120)
            {
                price = 875*2;
            }


            else if (minutes >= 121 && minutes <= 240)
            {
                price = 875 * 3;
            }
                      

            return price;


         
           
        }
    }
}

