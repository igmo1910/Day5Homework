using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    public class CustomerManager : IBaseService<Customer>
    {
        public void Add(Customer customer)
        {

            if (UserValidation(customer))
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

        public bool UserValidation(Customer customer)
        {
            return true;
        }
    }
}
