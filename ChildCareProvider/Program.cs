namespace SeniorCareProvider
{
    public class Program
    {
        static void Main (string[] args)
        {
            DisplayMessage.ShowDisplayText();

            DisplayMessage.RequestFirstName();

            UserInfo.FirstName = Console.ReadLine();

            DisplayMessage.RequestLastName();

            UserInfo.LastName = Console.ReadLine();

            DisplayMessage.RequestAge();

            UserInfo.Age = Console.ReadLine();

            var isValidAge = AgeValidator.IsValidAge(UserInfo.Age);

            if (isValidAge)
                DisplayMessage.DisplayMessageForValidUser(UserInfo.GetFullName());
            else
                DisplayMessage.DisplayMessageForInvalidUser(UserInfo.GetFullName());
        }
    }
}