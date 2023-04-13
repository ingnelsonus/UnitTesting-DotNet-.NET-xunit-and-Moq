using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class CalcOperationsTests:IDisposable
    {
        [Fact]
        public void Add_GiveTwoIntValues_ReturnsInt()
        {
            //Arrange
            var calc = new CalcOperations();

            //Act
            var result = calc.Add(1,2);

            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(3,result);
        }


        [Fact]
        public void AddDouble_GiveTwoDoubleValues_ReturnsDouble()
        {
            //Arrange
            var calc = new CalcOperations();

            //Act
            var result = calc.AddDouble(1.2, 3.5);

            //Assert
            Assert.IsType<double>(result);
            Assert.Equal(4.7,result,0);
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
