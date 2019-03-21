using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public enum EmailStatus { Potential, Current, Past}

    public class EmailPoco
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmailStatus EmailStatusOfCustomer { get; set; }
        public string Email { get; set; }

        public EmailPoco() { }
        public EmailPoco(string firstName, string lastName, EmailStatus emailStatusOfCustomer, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailStatusOfCustomer = emailStatusOfCustomer;
            Email = email;
        }
    }
}
