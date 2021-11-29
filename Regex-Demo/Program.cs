using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------Welcome to User Registration Program----------");
            Console.WriteLine("\n Please enter user's First Name--");
            string firstName = Console.ReadLine();
            RegularExp.FirstName(firstName);                                 //taking user input and passing it in first name method of regular exp class
           // string lastName = Console.ReadLine();
            //RegularExp.LastName(lastName);                                  //taking user input and passing it in last name method of regular exp class
            //Console.WriteLine("\n Please enter user's Email Id's--");
            //string email = Console.ReadLine();
            //RegularExp.Email(email);                                        //email entry
            //Console.WriteLine("\n Please enter user's MobileNumber--");
            //string mobile = Console.ReadLine();
            //RegularExp.Mobile(mobile);

           

        }
    }
}
