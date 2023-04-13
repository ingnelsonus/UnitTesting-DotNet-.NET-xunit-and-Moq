using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public static class TestDatashare
    {
        public static IEnumerable<object[]> IsOddOrEventData
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, true };
            }
        }
    }
}
