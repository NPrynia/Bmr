using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmr
{
    class Person
    {
        public static double BMR(double weight, Double growth, double age, int gender)
        {
            double bmr = 0;
            if (gender == 0)
            {
                bmr = (10 * weight + 6.25 * growth - 5 * age + 5);
            }
            if (gender == 1)
            {
                bmr = (10 * weight + 6.25 * growth - 5 * age - 161);
            }

            return bmr;
        }
    }
}
