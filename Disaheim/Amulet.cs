using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    //Make Amulet a childclass to the Merchandise parent class
    public class Amulet : Merchandise
    {
        private Level quality;

        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
           
        }

  //      private string itemId;

		//public string ItemId
		//{
		//	get { return itemId; }
		//	set { itemId = value; }
		//}

		private string design;

		public string Design
		{
			get { return design; }
			set { design = value; }
        }

        //Amulet constructor with keyword to call the itemId's constructor from Merchandise Class
        public Amulet(string itemId, Level quality, string design)
        {
            this.itemId = itemId;
            this.quality = quality;
            this.design = design;
        }

        //Amulet Chaining
        public Amulet(string itemId, Level quality) :

            this(itemId, quality, null)
        { }

        //Amulet Chaining
        public Amulet(string itemId) :

            this(itemId, Level.medium, null)
        { }



        //Override string
        public override string ToString()
        {                        
            return $"ItemId: {itemId}, Quality: {quality}, Design: {design}";
        }




    }
}
