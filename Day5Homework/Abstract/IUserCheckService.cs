using System;
using System.Collections.Generic;
using System.Text;
using Day5Homework.Entity;

namespace Day5Homework.Abstract
{
    public interface IUserCheckService
    {
        bool ValidateUser(Customer customer);
    }
}
