using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2020
{
    public class Person
    {
        public Person(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string GetFullName()
        {
            return this.Name + " " + this.Surname;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - this.DateOfBirth.Year;
        }

    }
}
