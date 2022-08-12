using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorCareProvider
{/// <summary>
/// The AgeValidator class validates the user age. it has a function to convert age into an integer
/// </summary>
    public class AgeValidator
    {
        public static bool IsValidAge(string age)
        {
            var isAgeInteger = int.TryParse(age, out int ageValue);
            try
            {

            }
            catch (Exception mc)
            {

                Console.WriteLine("Something's not right!");
            }
            if (isAgeInteger && ageValue > 65)
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
