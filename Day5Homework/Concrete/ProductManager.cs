using System;
using Day5Homework.Abstract;
using Day5Homework.Entity;

namespace Day5Homework.Concrete
{
    class ProductManager : IProductService
    {
        public void Sell(Product product, Customer customer, Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " " + campaign.CampaignName + " ile satın aldı: " + product.ProductName);
        }

        public void Sell(Product product, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " satın aldı: " + product.ProductName);
        }
    }
}
