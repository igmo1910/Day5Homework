using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
