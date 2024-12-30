using System;
using System.Collections.Generic;

namespace CRUD_Kopilovs.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
