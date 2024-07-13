using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    class Model
    {
        public string user;
        public int usercode;
        public string user_email;
        private string password;

        public Model(string user_name, int user_code, string useremail)
        {
            user = user_name;
            usercode = user_code;
            user_email = useremail;
           
            
        }

        public string Password
        {
            get { return Password; }
            set
            {
                password = value;

            }
        }

        public bool validation()
        {
            if(user == "Admin" && usercode == 2341)
            {
                Console.WriteLine("User Logged In Successfully");
                return true;
            }
            return false;
        }
    }
}
