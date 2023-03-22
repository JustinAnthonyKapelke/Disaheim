using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {

        // Private field stores a list of Book obejcts
        private List<Book> books = new List<Book>();

        // Private field stores a list of Amulet obejcts
        private List<Amulet> amulets = new List<Amulet>();

        // Private field stores a list of Course objects
        private List<Course> courses = new List<Course>();

        //Property Books
        public List<Book> Books
        {
            get
            {
                return books;
            }
        }


        //Property Amulet
        public List<Amulet> Amulets
        {
            get
            {
                return amulets;
            }
        }

        //Property Courses

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }



        //Create a contructor for the controller class
        public Controller()
        {
            books = new List<Book>();
            amulets = new List<Amulet>();
        }


        //Add book to list method
        public void AddToList(Book book)
        { books.Add(book); }


        //Add amulet to list method
        public void AddToList(Amulet amulet)
        { amulets.Add(amulet); }

        //Add course to list method
        public void AddToList(Course course)
        { courses.Add(course); }

    }
        
}
