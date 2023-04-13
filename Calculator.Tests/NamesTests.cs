using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class NamesTests
    {
        [Fact]
        public void MakeFullNameTests()
        {
            //Arrange
            var names = new Names();


            //Act
            var result = names.MakeFullName("Fane", "Us");

            //Assert
            Assert.IsType<string>(result);
            Assert.Contains("fane",result,StringComparison.InvariantCultureIgnoreCase);
            Assert.Contains("us", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("fane",result,StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("us", result,StringComparison.InvariantCultureIgnoreCase);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+",result);
            Assert.Equal("fane us", result,ignoreCase:true);

        }

        [Fact]
        public void NickName_MustBeNull()
        {
            //Arrange
            var names = new Names();
            names.NickName = "friendly man";

            //Act
            var result = names.NickName;

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {

            //Arrange
            var names = new Names();
            names.NickName = "friendly man";

            //Act
            var result = names.MakeFullName("fane","us");

            //Assert
            Assert.NotNull(result);
            Assert.True(!string.IsNullOrEmpty(result));
        }



    }
}
