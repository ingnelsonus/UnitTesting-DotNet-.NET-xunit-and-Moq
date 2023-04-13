using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    [Collection("Customer")]
    public class CustomerdetailsTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerdetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirstNameAndLastName_ReturnsFullName()
        {

            //Arrange
            //var customer = new Customer();
            var firsName = "fane";
            var lastName = "us";

            //Act
            var result = _customerFixture.cust.GetFullName(firsName, lastName);


            //Assert
            Assert.Equal($"{firsName} {lastName}",result,ignoreCase:true);
        }

    }
}
