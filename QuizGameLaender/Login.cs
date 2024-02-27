using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameLaender
{
    public class Login
    {
        public long Id { get; }
        public string NutzerName { get; set; }
        public string Password { get; set; }

        public Login(string nutzerName, string password)
        {
            NutzerName = nutzerName;
            Password = password;
        }
    }
}
