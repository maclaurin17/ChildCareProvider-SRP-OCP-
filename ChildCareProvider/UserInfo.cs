using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorCareProvider
{/// <summary>
/// The UserInfo class has two methods, one gets the user's full name and the other gets the user's age
/// </summary>
    public class UserInfo
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Age { get; set; }

        public static string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static string GetAge()
        {
            return Age;


        }
    }
}
