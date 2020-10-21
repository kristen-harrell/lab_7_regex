using System;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace lab_7_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            bool validName = IsValidName(name);

            Console.WriteLine(validName);

            Console.WriteLine("Enter your email: ");
            string email = Console.ReadLine();

            bool validEmail = IsValidEmail(email);

            Console.WriteLine(validEmail);

            Console.WriteLine("Enter your phone number in the following format- xxx-xxx-xxxx: ");
            string phone = Console.ReadLine();

            bool validPhone = IsValidPhone(phone);

            Console.WriteLine(validPhone);

            Console.WriteLine("Enter today's date in the following format: dd/mm/yyy: ");
            string date = Console.ReadLine();

            bool validDate = IsValidPhone(date);

            Console.WriteLine(validDate);

        }

        public static bool IsValidName(string name)
        {

            Regex reg = new Regex(@"^[a-zA-Z ]+$");


            if (reg.IsMatch(name))
            {
                return true;
            }

            else
            {
                return false;
            }



        }

        public static bool IsValidEmail(string email)
        {

            Regex rege = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");


            if (rege.IsMatch(email))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {

            Regex rege = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");


            if (rege.IsMatch(phone))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool IsValidDate(string date)
        {

            Regex rege = new Regex(@"^(((0?[1-9]|[12]\d|3[01])[\.\-\/](0?[13578]|1[02])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|[12]\d|30)[\.\-\/](0?[13456789]|1[012])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|1\d|2[0-8])[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|(29[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00|[048])))$");


            if (rege.IsMatch(date))
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
