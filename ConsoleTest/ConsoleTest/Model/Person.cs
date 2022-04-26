using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string _f, string _l)
        {
            FirstName = _f;
            LastName = _l;
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
