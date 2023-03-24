using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    //Make Book a childclass to the Merchandise parent class
	public class Book : Merchandise
    {
		
		//private string itemId;

		//public string ItemId
		//{
		//	get { return itemId; }
		//	set { itemId = value; }
		//}


		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}


		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

        //Book constructor with keyword to call the itemId's constructor from Merchandise Class
        public Book (string itemId, string title, double price)
		{
			this.ItemId = itemId;
			this.title = title;
			this.price = price;			
		}

		//Book Chaining
		public Book(string itemId, string title) :
		
			this(itemId, title, 0)
        { }

        //Book Chaining
        public Book(string itemId) :

            this(itemId, null, 0)
        { }

		// Get Value metode book
		public override double GetValue()
		{ 
		 return Price;
		}

        //Override string
        public override string ToString()
        {
			return $"ItemId: {ItemId}, Title: {title}, Price: {price}";
		}


    }
}
