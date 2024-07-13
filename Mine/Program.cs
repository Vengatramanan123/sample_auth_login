using System;
using Mine;

namespace Mine
{
    class Mine
    {   
        static void Main()
        {
            string user_name;
            string user_email;
            int user_code;
            string user_password;
            
            try
            {
                
                Console.WriteLine("Welcome to Simple Auth Login\n");

                Console.Write("Enter your username : ");
                user_name = Console.ReadLine();

                Console.Write("Enter your code : ");
                user_code = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your email : ");
                user_email = Console.ReadLine();

                Console.Write("Enter your password : ");
                user_password = Console.ReadLine();

                Model login = new Model(user_name, user_code, user_email);
                login.Password = user_password;

                if (user_password !="")
                {
                    login.validation();
                }
                else
                {
                    Console.WriteLine("\nAuthentication Failed");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}