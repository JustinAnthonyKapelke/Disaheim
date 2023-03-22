
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Disaheim
{
    public class AmuletRepository 
    {


        //Private field Amulet list
        private List<Amulet> amulets = new List<Amulet>();

        //Add amulet to Amulet list
        public void AddAmulet (Amulet amulet)
        {
            amulets.Add (amulet);   
        }
        
        //Get each amulet with itemID
        public Amulet GetAmulet (string itemID)
        {
            foreach (Amulet amulet in amulets) 
            {
                if (amulet.ItemId == itemID)
                    return amulet;
            }
            return null;
        }

        //Get total value of of amulets
        public double GetTotalValue()
        {
            double totalValue = 0.0;
            Utility utility = new Utility();

            foreach (Amulet amulet in amulets)
            {
                totalValue += utility.GetValueOfAmulet(amulet);
            }
            return totalValue;
        }

    }
}
