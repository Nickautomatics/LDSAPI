using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models.Teacher
{
    public class TeacherModel
    {
        public TeacherModel()
        {
        }


        string password;
        string username;

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
            }
        }

        
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
        
    }
}
