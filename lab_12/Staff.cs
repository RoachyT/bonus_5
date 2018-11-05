using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Staff : Person, IComparable
    {
        public string School { get; set; }
        public double Pay { get; set; }
        public Staff(string school, double pay, string lastName, string firstName, string address) : base(lastName, firstName, address)
        {
            Pay = pay;
            School = school;
        }
        public Staff()
        {
        }
        public override int CompareTo(object obj)
        {
            return this.LastName.CompareTo(((Person)obj).LastName);
        }



        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}\nSchool: {School}\nPay: ${Pay}";
        }
    }
}
