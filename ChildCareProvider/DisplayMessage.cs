using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorCareProvider
{/// <summary>
/// The DisplayMessage class handles parts of the program that displays messages with the users
/// </summary>
    public class DisplayMessage
    {
        public static void ShowDisplayText()
        {
            Console.WriteLine("Welcome to Purple Academy Senior Care Facility");
        }

        public  static void RequestFirstName()
        {
            Console.WriteLine("Please provide your first name");
        }

        public static void RequestLastName()
        {
            Console.WriteLine("Please provide your last name");
        }
        public static void RequestAge()
        {
            Console.WriteLine("Please provide your age");
        }

        public static void DisplayMessageForInvalidUser(string fullName)
        {
            Console.WriteLine($"Sorry {fullName}, " +
                $"we do not provide care for persons below age 65");
        }

        public static void DisplayMessageForValidUser(string fullName)
        {
            Console.WriteLine($"You are welcome {fullName}. Please proceed to next step");
        }
    }
}
