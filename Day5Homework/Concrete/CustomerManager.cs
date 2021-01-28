using System;
using Day5Homework.Abstract;
using Day5Homework.Entity;

namespace Day5Homework.Concrete
{
    public class CustomerManager : IBaseService<Customer>
    {
        private IUserCheckService _userCheckService;

        public CustomerManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void Add(Customer customer)
        {

            if (_userCheckService.ValidateUser(customer))
            {
                Console.WriteLine(customer.FirstName + " oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Kullanıcı geçerli değil!");
            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " güncellendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " silindi.");
        }
    }
}
