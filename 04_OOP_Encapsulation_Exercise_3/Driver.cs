using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_3
{
    public class Driver
    {
        private const decimal _BaseInsuranceCostPerMonthConst = 120m;
        private decimal _costOfInsurancePerMonth;
        private int _age;

        public int Age
        {
            set
            {
                if (value < 16 || value > 25)
                    throw new ArgumentOutOfRangeException("You are the wrong age range");

                _age = value;

            }
        }

        public decimal CostOfInsurancePerMonth
        {
            get => _costOfInsurancePerMonth;
            private set
            {
                if (value >= 16 && value <= 19)
                    _costOfInsurancePerMonth = _BaseInsuranceCostPerMonthConst * 1.9m;

                else if (value >= 20 && value <= 22)
                    _costOfInsurancePerMonth = _BaseInsuranceCostPerMonthConst * 1.6m;

                else if (value >= 23)
                    _costOfInsurancePerMonth = _BaseInsuranceCostPerMonthConst * 1.5m;
            }
        }

        public Driver(int age)
        {
            Age = age;
            CostOfInsurancePerMonth = age;
        }
    }
}
