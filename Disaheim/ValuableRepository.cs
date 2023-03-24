using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        //Private field and instantiate a new empty list
        private List<IValuable> valuables = new List<IValuable>();

        // Add Merchandize method
        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        // Get Merchandise method
        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise && (valuable as Merchandise).ItemId == id)
                    return valuable;
                else if (valuable is Course && (valuable as Course).Name == id)
                    return valuable;
            }
            return null;
        }


        // GetTotalValue  method
        public double GetTotalValue()
        {
            double totalValue = 0.0;            

            foreach (IValuable valuable in valuables)
            {
                totalValue += valuable.GetValue();
            }
            return totalValue;
        }

        public int Count()
        {
            int mycount = valuables.Count;
            return mycount;
        }

    }
}
