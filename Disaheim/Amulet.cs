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
        //LowQualityValue Property
        private static double lowQualityValue = 12.5;

        public static double LowQualityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = value; }
        }

        // MediumQualityValue property
        private static double mediumQualityValue = 20.0;

        public static double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = value; }
        }

        // HighQualityValue property
        private static double highQualityValue = 27.5;

        public static double HighQualityValue
        {
            get { return highQualityValue; }
            set { highQualityValue = value; }
        }

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
            this.ItemId = itemId;
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


        //Get Value metode
        public override double GetValue()
        {
            double price = 0;

            if (Quality == Level.low)
            {
                price = 12.5;
            }

            else if (Quality == Level.medium)
            {
                price = 20.0;
            }

            else if (Quality == Level.high)
            {
                price = 27.5;
            }

            return price;
        }


        //Override string
        public override string ToString()
        {                        
            return $"ItemId: {ItemId}, Quality: {quality}, Design: {design}";
        }

        

    }
}
