//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Disaheim
//{
//    public class MerchandiseRepository
//    {
//        //Private field and instantiate a new empty list
//        private List<Merchandise> merchandises = new List<Merchandise>();

//        // Add Merchandize method
//        public void AddMerchandise(Merchandise merchandise)
//        {
//            merchandises.Add(merchandise);
//        }

//        // Get Merchandise method
//        public Merchandise GetMerchandise(string itemId)
//        {
//            foreach (Merchandise merchandise in merchandises)
//            {
//                if (merchandise.ItemId == itemId)
//                return merchandise;
//            }
//            return null;
//        }


//        // GetTotalValue  method
//        public double GetTotalValue()
//        {
//            double totalValue = 0.0;
//            Utility utility = new Utility();


//            foreach (Merchandise merchandise in merchandises)
//            {
//                totalValue += utility.GetValueOfMerchandise(merchandise);
//            }
//            return totalValue;
//        }




//    }
//    // Return total value of all books in Books
//    //        public double GetTotalValue()
//    //        { 
//    //            // totalValue variable
//    //            double totalValue = 0.0;
//    //            foreach (Book book in books)
//    //            {
//    //                totalValue = totalValue + book.Price;
//    //            }   
//    //            return totalValue;                     
//    //        }

//}
