using System;

namespace ClassLibraryPassword
{
    class Program
    {
        static void Main(string[] args)
        {

            PasswordChecker passwordChecker = new PasswordChecker();

            Console.WriteLine(passwordChecker.ValidatePassword("Vladimir75VoV_"));
        }
    }
}
