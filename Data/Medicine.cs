using System.Security.AccessControl;
using System.Xml.Linq;

namespace Lamera_Midterms.Data
{
    public class Medicine
    {
        public string name { get; set; }
        public string genericName { get; set; }
        public double price {  get; set; }
        public double quantity {  get; set; }
        private double totalTransactionPrice;
       
        public Medicine()
        {
            name = "";
            genericName = "";
            price = 0;
            quantity = 0;
        }
        public Medicine(string name, string genericName, double price, double quantity)
        {
            name = name;
            genericName = genericName;
            price = price;
            quantity = quantity;
        }
        private void CalcTotalTransactionPrice(double quantity)
        {
            totalTransactionPrice = price * quantity;
        }
        public double GetTotalTransactionPrice(double quantity)
        {
            CalcTotalTransactionPrice(quantity);
            return totalTransactionPrice;
        }

    }
}
