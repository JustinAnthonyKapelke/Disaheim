using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository 
    {
        //Book field
        private List<Book> books = new List<Book>();

        //Add new book to list
        public void AddBook(Book book)
        { 
           books.Add(book);
        }


        // If a a book in Books wich has itemID as ItemID it is returned. Else null is returned.
        public Book GetBook (string itemID)
        {
            //Return each book in Books wich has itemID
            foreach (Book book in books) 
            {
                if (book.ItemId == itemID)
                    return book;                                 
            }
            return null;           
        }
        
        // Return total value of all books in Books
        public double GetTotalValue()
        { 
            // totalValue variable
            double totalValue = 0.0;
            foreach (Book book in books)
            {
                totalValue = totalValue + book.Price;
            }   
            return totalValue;                     
        }
      
    }
}