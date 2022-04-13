using System;
using System.Collections.Generic;

namespace SalesService
{
    public class SalesTransaction
    {

        private readonly IGetPayment _paymentService;
        private readonly IGetSalesArticle _salesArticleService;

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public List<SalesArticle> Articles { get; set; } = new List<SalesArticle>();
        public Payment PayEvent { get; set; }

        public SalesTransaction()
        {
            _paymentService = GetPaymentServiceFactory.GeneratePaymentService();
            _salesArticleService = GetSalesArticleServiceFactory.GenerateSalesArticleService();
            Id = Convert.ToInt32(DateTime.UtcNow);
        }

        public void GeneratePayment(decimal amount)
        {
            PayEvent = _paymentService.GeneratePayment(amount);
        }

        public int ProvideArticleNumber()
        {
            int articleNumber = 12;
            return articleNumber;
        }

        public void AddNewSalesArticle()
        {
            int articleNumber = ProvideArticleNumber();

            SalesArticle newSalesArticle = _salesArticleService.GetSalesArticle(articleNumber);
            Articles.Add(newSalesArticle);
        }
    }
}
