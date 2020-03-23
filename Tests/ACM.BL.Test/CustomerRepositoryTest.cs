using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var CustomerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                //here customerid will give error because customer id is private so we are going to pass the customer id into the cinstructor
                EmailAddress = "deril.xavier@kanini.com",
                FirstName="Deril",
                LastName="Xavier"

            };
            //-- Act
            var actual =CustomerRepository.Retrieve(1);
            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);



        }
    }
}
