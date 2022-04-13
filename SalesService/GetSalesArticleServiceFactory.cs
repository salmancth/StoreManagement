using System;
namespace SalesService
{
    public class GetSalesArticleServiceFactory
    {
        public static IGetSalesArticle GenerateSalesArticleService()
        {
            return new SalesArticleService();
        }
    }
}
