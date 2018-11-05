using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_12
{
    class Validation
    {
        private int _numbers;
        private string _letters;
        public Validation()
        {
        }

        public Validation(string letters, int numbers)
        {
            _numbers = numbers;
            _letters = letters;
        }

        public static bool AreNumbersValid(int numbers)
        {

            if (Regex.IsMatch(numbers.ToString(), @"[0-9]"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool BetweenOneHundred(int numbers)
        {
            if (numbers > 100 && numbers < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool AreLettersValid(string letters)
        {
            if (Regex.IsMatch(letters, @"[A-z}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
