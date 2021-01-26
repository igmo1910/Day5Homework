using Day5Homework.Entity;

namespace Day5Homework.Abstract
{
    public interface IProductService
    {
        void Sell(Product product, Customer customer, Campaign campaign);
        void Sell(Product product, Customer customer);
    }
}
