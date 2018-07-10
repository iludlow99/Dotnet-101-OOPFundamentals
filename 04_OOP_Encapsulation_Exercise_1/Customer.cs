using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_1
{
    public class Customer
    {
        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Hey");
                }
                else
                {
                    _firstName = value; 
                }

            }
        }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Please enter a name");
                }
                else
                {
                    _lastName = value;
                }

            }
        }

        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value > 120)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "You're way too old!");
                }
                else
                {
                    _age = value; 
                }

            }
        }

    }
}
