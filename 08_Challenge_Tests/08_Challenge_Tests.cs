using System;
using System.Collections.Generic;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Challenge_Tests
{
    [TestClass]
    public class _08_Challenge_Tests
    {
        [TestMethod]
        public void AddDriverToList()
        {
            InsuranceRepository _insuranceRepo = new InsuranceRepository();
            InsurancePoco driverOne = new InsurancePoco();
            InsurancePoco driverTwo = new InsurancePoco();
            InsurancePoco driverThree = new InsurancePoco();

            _insuranceRepo.AddDriverToList(driverOne);
            _insuranceRepo.AddDriverToList(driverTwo);
            _insuranceRepo.AddDriverToList(driverThree);

            int actual = _insuranceRepo.GetInsuranceList().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatingInssuranceCost()
        {
            InsuranceRepository _insuranceRepo = new InsuranceRepository();
            InsurancePoco driverOne = new InsurancePoco("Sam", 2,2,2,2);

            decimal actual = _insuranceRepo.InsuranceCost(driverOne);
            decimal expected = 175;

            Assert.AreEqual(expected, actual);
        }
    }
}
