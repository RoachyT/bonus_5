using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class ArchivedStudent : Student, IComparable
    {
        public int FinalScore { get; set; }

        public ArchivedStudent(int finalScore, string degreeProgram, int year, double fee, string lastName, string firstName, string address) : base(degreeProgram, year, fee, lastName, firstName, address)
        {
            FinalScore = finalScore;
        }
        public override int CompareTo(object obj)
        {
            return this.LastName.CompareTo(((Person)obj).LastName);
        }
        public override string ToString()
        {
            return base.ToString() + $"{FinalScore}";
        }
    }
}
