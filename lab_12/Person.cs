using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Person: IComparable
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }

        public Person(string lastName, string firstName, string address)
        {
            LastName = lastName;
            FirstName = firstName;
            Address = address;
        }

        public Person() 
        {
        }

        public virtual int CompareTo(object obj)
        {
            return this.LastName.CompareTo(((Person)obj).LastName);
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}";
        }
    }
}
