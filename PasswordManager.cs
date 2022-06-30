using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces
{
    internal class PasswordManager :IDisplayable, IResetable
    {
        public void Display()
        {
            
        }

        public void Reset()
        {
            
        }

        private string Password
        { get; set; }
        public bool Hidden
        { get; private set; }
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }
    }
}
