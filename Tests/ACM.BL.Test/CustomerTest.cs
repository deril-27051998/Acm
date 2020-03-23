using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Deril",
                
            };
            string Expected = "Deril";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(Expected, actual);
        }
        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Xavier",
                EmailAddress="derilxavi@gmail.com"
            };
            bool Expected = true;

            // -- Act
            bool actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(Expected, actual);


        }
    }
}
