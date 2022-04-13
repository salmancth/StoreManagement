using System;
namespace SalesService
{
    public class PrintedMatterPurchase : SalesArticle
    {
        public PrintedMatterPurchase()
        {
        }

        public override decimal ValueAddedTax()
        {
            return Price * (decimal).06;
        }

        public override decimal FullPrice()
        {
            return Price * (decimal)1.06;
        }
    }
}
