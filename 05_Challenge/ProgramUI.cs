using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public class ProgramUI
    {
        EmailPoco _emailPoco = new EmailPoco();
        EmailRepository _emailRepo = new EmailRepository();

        public void Run()
        {
            bool ProgramIsStillRunning = true;

            while (ProgramIsStillRunning)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do today?\n" +
                    "1. Create\n" +
                    "2. Read List\n" +
                    "3. Update list\n" +
                    "4. Delete individual");
                string UserInputMenu = Console.ReadLine().ToLower();
                switch (UserInputMenu)
                {
                    case "1":
                    case "create":
                        AddCustomerToList();
                        break;
                    case "2":
                    case "read":
                        GetListOfCustomers();
                        break;
                    case "3":
                    case "update":
                        UpdateList();
                        break;
                    case "4":
                    case "delete":
                        DeleteCustomerFromList();
                        break;
                }
            }
        }

        private void DeleteCustomerFromList()
        {
            Console.Clear();
            GetListOfCustomers();

            Console.WriteLine("What is the first name of the customer you are trying to remove?");
            string RemoveFirstName = Console.ReadLine();

            Console.WriteLine("What is the last name of the customer you are trying to remove?");
            string RemoveLastName = Console.ReadLine();

            bool success = _emailRepo.RemoveCustomerFromListBySpecification(RemoveFirstName, RemoveLastName);
            if (success == true)
            {
                Console.WriteLine($"The customer was successfully removed from the list.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The customer was not able to be removed from the list. Please double check your input.");
                Console.ReadKey();

            }
        }

        private void UpdateList()
        {
            Console.Clear();
            GetListOfCustomers();

            Console.WriteLine("What is the first name of the customer you are trying to change?");
            string ChangeFirstName = Console.ReadLine();

            Console.WriteLine("What is the last name of the customer you are trying to change?");
            string ChangeLastName = Console.ReadLine();

            Console.WriteLine("What would you like to change?\n" +
                "1. FirstName\n" +
                "2. Last Name\n" +
                "3. Type of Customer\n" +
                "4. Email");
            string UserinputFromMenu = Console.ReadLine().ToLower();

            switch (UserinputFromMenu)
            {
                case "1":
                case "first name":
                    Console.WriteLine("What is the first name of the customer now?");
                    string UpdatedFirstName = Console.ReadLine();
                    _emailRepo.UpdateCustomerListByFirstNameSpecification(ChangeFirstName, ChangeLastName, UpdatedFirstName);
                    break;

                case "2":
                case "last name":
                    Console.WriteLine("What is the last name of the customer now?");
                    string UpdatedLastName = Console.ReadLine();
                    _emailRepo.UpdateCustomerListByLastNameSpecification(ChangeFirstName, ChangeLastName, UpdatedLastName);
                    break;

                case "3":
                case "type":
                    Console.WriteLine("what is the Type of customer?\n" +
                                    "1. Potential\n" +
                                    "2. Current\n" +
                                    "3. Past");
                    string Userinput = Console.ReadLine().ToLower();

                    EmailStatus _UpdatedemailStatus = new EmailStatus();
                    switch (Userinput)
                    {
                        case "1":
                        case "potential":
                            _UpdatedemailStatus = EmailStatus.Potential;
                            break;

                        case "2":
                        case "current":
                            _UpdatedemailStatus = EmailStatus.Current;
                            break;

                        case "3":
                        case "past":

                            _UpdatedemailStatus = EmailStatus.Past;
                            break;

                    }
                    _emailRepo.UpdateCustomerListByTypeSpecification(ChangeFirstName, ChangeLastName, _UpdatedemailStatus);
                    break;
                    
                case "4":
                case "email":
                    Console.WriteLine("What is the email address of the customer now?");
                    string UpdatedEmail = Console.ReadLine();
                    _emailRepo.UpdateCustomerListByEmailSpecification(ChangeFirstName, ChangeLastName, UpdatedEmail);
                    break;
            }
        }

        private void GetListOfCustomers()
        {
            Console.Clear();
            List<EmailPoco> _emailPoco = _emailRepo.GetEmailList();

            Console.WriteLine("First Name       LastName      Type       Email");
            foreach (EmailPoco emailPoco in _emailPoco)
            {
                Console.WriteLine($"{emailPoco.FirstName}       {emailPoco.LastName}      {emailPoco.EmailStatusOfCustomer}       {emailPoco.Email}");
            }
            Console.ReadKey();
        }

        private void AddCustomerToList()
        {
            Console.Clear();
            Console.WriteLine("What is the Customers first name?");
            string FirstName = Console.ReadLine();

            Console.WriteLine("What is the customers last name?");
            string LastName = Console.ReadLine();

            Console.WriteLine("what is the Type of customer?\n" +
                "1. Potential\n" +
                "2. Current\n" +
                "3. Past");
            string Userinput = Console.ReadLine().ToLower();

            EmailStatus _emailStatus = new EmailStatus();
            switch (Userinput)
            {
                case "1":
                case "potential":
                    _emailStatus = EmailStatus.Potential;
                break;

                case "2":
                case "current":
                    _emailStatus = EmailStatus.Current;
                break;

                case "3":
                case "past":

                   _emailStatus = EmailStatus.Past;
                break;

            }

            Console.WriteLine("What is the customers email address?");
            string EmailAddress = Console.ReadLine();

            EmailPoco CustomerToList = new EmailPoco(FirstName, LastName, _emailStatus, EmailAddress);

            _emailRepo.AddPersonToEmailList(CustomerToList);

            Console.WriteLine("Customer Was added to the email list. Press any key to continue.");
            Console.ReadKey();
        }
    }
}
