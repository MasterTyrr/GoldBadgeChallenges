using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Tests
{
    [TestClass]
    public class _03_Challenge_Tests
    {
        [TestMethod]
        public void AddEventsToList()
        {
            OutingRepository _outingRepo = new OutingRepository();
            Outing item1 = new Outing();
            Outing item2 = new Outing();
            Outing item3 = new Outing();

            _outingRepo.AddEventToList(item1);
            _outingRepo.AddEventToList(item2);
            _outingRepo.AddEventToList(item3);

            int actual = _outingRepo.GetEventList().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void OutingRepo_GetList()
        {
            // Arrange
            OutingRepository _outingRepo = new OutingRepository();
            Outing item1 = new Outing();

            // Act
            _outingRepo.AddEventToList(item1);
            List<Outing> ItemList = _outingRepo.GetEventList();

            bool expected = true;
            bool actual = ItemList.Contains(item1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepo_Add()
        {
            // Arrange
            OutingRepository _outingRepo = new OutingRepository();
            Outing item1 = new Outing(10, DateTime.Today, 25, 250, EventType.Golf);
            Outing item2 = new Outing(15, DateTime.Today, 20, 300, EventType.Golf);

            // Act
            _outingRepo.AddEventToList(item1);
            _outingRepo.AddEventToList(item2);
            List<Outing> ItemList = _outingRepo.GetEventList();

            decimal expected = 550;
            decimal actual = _outingRepo.AllEventTotalCost(ItemList);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
