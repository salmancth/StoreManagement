using System;
namespace SalesService
{
    public class FoodPurchase : SalesArticle
    {
        public FoodPurchase()
        {
        }

        public override decimal ValueAddedTax()
        {
            return Price * (decimal).12;
        }

        public override decimal FullPrice()
        {
            return Price * (decimal)1.12;
        }
    }
}
