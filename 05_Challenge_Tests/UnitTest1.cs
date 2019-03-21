using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void EmailRepositroy_AddItemToMenu()
        {
            EmailRepository _EmailRepo = new EmailRepository();
            EmailPoco item1 = new EmailPoco();
            EmailPoco item2 = new EmailPoco();
            EmailPoco item3 = new EmailPoco();

            _EmailRepo.AddPersonToEmailList(item1);
            _EmailRepo.AddPersonToEmailList(item2);
            _EmailRepo.AddPersonToEmailList(item3);

            int actual = _EmailRepo.GetEmailList().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepositroy_RemoveItemFromMenu()
        {
            EmailRepository _EmailRepo = new EmailRepository();
            EmailPoco item1 = new EmailPoco();
            EmailPoco item2 = new EmailPoco();
            EmailPoco item3 = new EmailPoco();

            _EmailRepo.AddPersonToEmailList(item1);
            _EmailRepo.AddPersonToEmailList(item2);
            _EmailRepo.AddPersonToEmailList(item3);

            _EmailRepo.RemoveCustomerFromList(item3);

            int actual = _EmailRepo.GetEmailList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepo_GetMenu()
        {
            // Arrange
            EmailRepository _EmailRepo = new EmailRepository();
            EmailPoco item1 = new EmailPoco();

            // Act
            _EmailRepo.AddPersonToEmailList(item1);
            List<EmailPoco> ItemList = _EmailRepo.GetEmailList();

            bool expected = true;
            bool actual = ItemList.Contains(item1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}


