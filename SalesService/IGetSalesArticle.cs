using System;
namespace SalesService
{
    public interface IGetSalesArticle
    {
        public SalesArticle GetSalesArticle(int articleNumber);
    }
}
