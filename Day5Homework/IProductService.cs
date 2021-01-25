using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    public interface IProductService
    {
        void Sell(Product product, Customer customer, Campaign campaign);
        void Sell(Product product, Customer customer);
    }
}
