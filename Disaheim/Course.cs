using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        //Private field name
        private string name;

        //Propert Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


       //Private field DurationInMinutes
        private int durationInMinutes;
        //Property DurationInMinutes

        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }



        //Course constructor
        public Course(string name, int durationInMinutes) 
        { 
            this.name = name;
            this.durationInMinutes = durationInMinutes;
        }

        //Constructor chain
        public Course(string name) :
            this(name, 0)
        { }

        //Override to string
        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}";

        }     
    }
}
