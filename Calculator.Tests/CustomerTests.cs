using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    [Collection("Customer")]
    public class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void CheckNameNotEmpty()
        {
            //Arrage
            //var customer = new Customer();

            //Act


            //Assert
            Assert.NotNull(_customerFixture.cust.Name);
            Assert.True(!string.IsNullOrEmpty(_customerFixture.cust.Name));

        }

        [Fact]
        public void CheckAgeRange()
        {
            //Arrange
            //var customer = new Customer();

            //Act


            //Assert
            Assert.InRange(_customerFixture.cust.Age, 18, 80);

        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            //Arrange
            //var customer = new Customer();

            //Act
            //var result = customer.getOrderByName("faneus");

            //Assert            
            //Assert.True(result > 0);
            Assert.Throws<ArgumentException>(()=> _customerFixture.cust.getOrderByName(""));
        }

    }
}
