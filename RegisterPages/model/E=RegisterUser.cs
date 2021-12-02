using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPages.model
{
    internal class E_RegisterUser
    {
        public event EventHandler registerUserEvent;
        public void RegisterAUser()
        {
            Console.WriteLine("User registered");
            if (registerUserEvent != null)
            {
                registerUserEvent(this, EventArgs.Empty);
            }
        }
    }
}
