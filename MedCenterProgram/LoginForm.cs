using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MedCenterProgram
{
    class LoginForm
    {
        string type;
        string Doctor = @"B:\VisualRepos\doctor_nurse.txt";
        string Admin = @"B:\VisualRepos\admin.txt";
        public void Welcoming()
        {
            Console.WriteLine("             Welcome to the MedSystem            ");
            Console.WriteLine("Write your username:");
            string login = Console.ReadLine();
            Console.WriteLine("Write your password:");
            string loginAndPassword = login + Console.ReadLine();
            Console.WriteLine("   Choose your catrgory(Doctor(D),Nurse(N),Admin(A)      ");
            string input = Console.ReadLine();

            switch (input.ToUpper())
            {
                case "D":
                    type = "Doctor";
                    checkLoginData(Doctor, loginAndPassword, type);
                    break;
                case "A":
                    type = "Admin";
                    checkLoginData(Admin, loginAndPassword, type);
                    break;
                case "N":
                    type = "Nurse";
                    checkLoginData(Doctor, loginAndPassword, type);
                    break;
                default:
                    Console.WriteLine("Try one more time");
                    Environment.Exit(0);
                    break;
            } 
            
        }
        private void checkLoginData(string Choice, string loginAndPassword, string type)
        {
            using (StreamReader loginCheck = new StreamReader(@""+Choice))
            {
                string buffer;
                do
                {
                    buffer = loginCheck.ReadLine();
                    if (String.Equals(loginAndPassword, buffer))
                    {
                        Console.WriteLine("Login is seccesful");
                        Console.WriteLine("Entering system....");
                        menu(type);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Login Failed");
                        Console.WriteLine(buffer);
                        break;
                    }
                } while (buffer != null);
               
                
            }
        }
        private void menu(string Choice)
        {
            Menu functions = new Menu();
            string Input;
            Console.WriteLine("             Good day!            ");
            Console.WriteLine("Choose the option that you want by entering number next to it");
            Console.WriteLine(type);
            if (Choice == "Doctor" || Choice == "Nurse")
            {
                Console.WriteLine("1. See list of staff");
                Console.WriteLine("2. See duty list");
                Console.WriteLine("3. Exit");
                Input = Console.ReadLine();
                switch (Input)
                {
                    case "1":
                        functions.ListOfEmployees();
                        break;
                    case "3":
                        functions.AddDuty();
                        break;
                        
                }
            }else
            {
                Console.WriteLine("1. See list of staff");
                Console.WriteLine("2. Set a duty");
                Console.WriteLine("3. See duty list");
                Console.WriteLine("4. Create Account");
                Input = Console.ReadLine();
            }

        }
    }

    
}
