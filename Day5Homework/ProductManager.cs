using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    class ProductManager : IBaseService<Product>, IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi");
        }

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
