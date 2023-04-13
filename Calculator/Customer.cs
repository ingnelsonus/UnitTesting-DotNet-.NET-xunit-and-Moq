using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Customer
    {
        public string Name { get; set; } = "faneus";
        public int Age => 35;

        public int getOrderByName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name");

            return 100;
        }

        public string GetFullName(string firsName,string lastName)
        {
            return $"{firsName} {lastName}";
        }

    }
}
