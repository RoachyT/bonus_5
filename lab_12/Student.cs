using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Student : Person, IComparable
    {

        public string DegreeProgram{ get; set; }
        protected int Year { get; set; }
        protected double Fee { get; set; }
        public Student(string degreeProgram, int year, double fee, string lastName, string firstName, string address) : base(lastName, firstName, address)
        {
            DegreeProgram = degreeProgram;
            Year = year;
            Fee = fee;
        }

        public Student()
        {
        }
        public override int CompareTo(object obj)
        {
            return this.LastName.CompareTo(((Person)obj).LastName);
        }


        public override string ToString()
        {
            return base.ToString() + $"\nYear: {Year}\nFee: ${Fee}";
        }
    }
        
}
