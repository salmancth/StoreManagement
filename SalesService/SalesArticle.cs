using System;
namespace SalesService
{
    public abstract class SalesArticle
    {
        public int ArticleNumber { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public SalesArticle()
        {
        }

        public virtual decimal ValueAddedTax()
        {
            return Price * (decimal) .25;
        }

        public virtual decimal FullPrice()
        {
            return Price * (decimal)1.25;
        }

    }
}
