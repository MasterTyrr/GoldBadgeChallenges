using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public class EmailRepository
    {
        private List<EmailPoco> EmailList;

        public EmailRepository()
        {
            EmailList = new List<EmailPoco>();
        }

        public void AddPersonToEmailList(EmailPoco NewPerson)
        {
            EmailList.Add(NewPerson);
        }

        public List<EmailPoco> GetEmailList()
        {
            var sorteditems = EmailList.OrderBy(x => x);
            return EmailList;
        }

        public void RemoveCustomerFromList(EmailPoco Customer)
        {
            EmailList.Remove(Customer);
        }

        public bool RemoveCustomerFromListBySpecification(string firstName, string lastName)
        {
            bool successful = false;
            foreach (EmailPoco customerList in EmailList)
            {
                if (customerList.FirstName == firstName && customerList.LastName == lastName)
                {
                    RemoveCustomerFromList(customerList);
                    successful = true;
                    break;
                }
            }
            return successful;
        }

        public void UpdateCustomerListByFirstNameSpecification(string firstName, string lastName, string NewFirstName)
        {

            EmailList.Where(w => w.FirstName == firstName && w.LastName == lastName).ToList().ForEach(s => s.FirstName = NewFirstName);
        }

        public void UpdateCustomerListByLastNameSpecification(string firstName, string lastName, string NewLastName)
        {

            EmailList.Where(w => w.FirstName == firstName && w.LastName == lastName).ToList().ForEach(s => s.LastName = NewLastName);
        }

        public void UpdateCustomerListByTypeSpecification(string firstName, string lastName, EmailStatus NewType)
        {

            EmailList.Where(w => w.FirstName == firstName && w.LastName == lastName).ToList().ForEach(s => s.EmailStatusOfCustomer = NewType);
        }

        public void UpdateCustomerListByEmailSpecification(string firstName, string lastName, string NewEmail)
        {

            EmailList.Where(w => w.FirstName == firstName && w.LastName == lastName).ToList().ForEach(s => s.Email = NewEmail);
        }
    }
}
