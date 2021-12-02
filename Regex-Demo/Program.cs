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
            bool flag = true;
            RegularExp regexSample = new RegularExp();
            while (flag)
            {
                Console.WriteLine("User Registration Validating Using Regular Expression!");
                Console.WriteLine("Enter your Choice Number to Execute the Regex Program Press- 1-Validate First Name, 2-Validate Last Name, 3-Validate Email,4-validate mobile number,5-Password1,6-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                { 
             case 1:
            
                Console.WriteLine("\n Please enter user's First Name--");
                string firstName = Console.ReadLine();
                RegularExp.FirstName(firstName);                                 //taking user input and passing it in first name method of regular exp class
                break;
            case 2:
                string lastName = Console.ReadLine();
                RegularExp.LastName(lastName);                                  //taking user input and passing it in last name method of regular exp class
                break;
            case 3:
                Console.WriteLine("\n Please enter user's Email Id's--");
                string email = Console.ReadLine();
                RegularExp.Email(email);                                        //email entry
                break;
            case 4:
                Console.WriteLine("\n Please enter user's MobileNumber--");
                string mobile = Console.ReadLine();
                RegularExp.Mobile(mobile);
                break;
            case 5:
                Console.WriteLine("Enter the Password to Check Validation");
                string Pwd = Console.ReadLine();                                 //password
                RegularExp.Password(Pwd);
                break;
            case 6:
                flag = false;
                break;
                 }
            
            }
        }
    }
}

                 



            
           