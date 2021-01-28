using System;
using System.Collections.Generic;
using System.Text;
using Day5Homework.Abstract;
using Day5Homework.Entity;

namespace Day5Homework.Concrete
{
    public class UserCheckManager:IUserCheckService
    {
        public bool ValidateUser(Customer customer)
        {
            return true;
        }
    }
}
