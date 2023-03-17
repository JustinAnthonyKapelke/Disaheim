using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise
    {

        //ItemId property
        public string itemId;
        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }
        ////Merchandise constructor
        //public Merchandise(string itemId)
        //{ 
        //    this.itemId = itemId;
        //}

        //Override to string
        public override string ToString() 
        {
            return $"ItemId: {itemId}";
        }
    }

}
