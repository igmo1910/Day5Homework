using System;

namespace Day5Homework.Entity
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
