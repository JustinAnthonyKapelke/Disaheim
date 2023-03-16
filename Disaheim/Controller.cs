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



    }
        
}
