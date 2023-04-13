using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{

    public class CalculatorFixture
    {
        public Calculations calc = new Calculations();
    }

    public class CalculationsTests:IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorFixture;

        public CalculationsTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            //Arrange
            var calc =_calculatorFixture.calc;

            //Act



            //Assert
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0,n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            //Arrange
            var calc = _calculatorFixture.calc;

            //Act


            //Assert
            Assert.Contains(13, calc.FiboNumbers);
        }

        //[Fact]
        //public void IsOdd_GiveOddValue_ReturnTrue()
        //{
        //    //Arrange
        //    var calc = _calculatorFixture.calc;

        //    //Act
        //    var result  = calc.IsOdd(1);

        //    //Assert
        //    Assert.True(result);
        //}

        //[Fact]
        //public void IsOdd_GiveOddValue_ReturnFalse()
        //{
        //    //Arrange
        //    var calc = _calculatorFixture.calc;

        //    //Act
        //    var result = calc.IsOdd(1);

        //    //Assert
        //    Assert.False(result);
        //}

        [Theory]
        //[InlineData(1,true)]
        //[InlineData(200, false)]
        [MemberData(nameof(TestDatashare.IsOddOrEventData),MemberType =typeof(TestDatashare))]
        public void IsOdd_TestOddAndEvent(int value,bool expected)
        {
            //Arrange
            var calc = _calculatorFixture.calc;

            //Act
            var result = calc.IsOdd(value);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
