using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model
{
    internal class Person
    {
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public DateTime DateOfBirth { get; set; }
        public Adresa Adresa { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
