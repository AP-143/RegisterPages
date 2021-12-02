using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPages.model
{
    internal class EmailVerification
    {
        public event EventHandler emailVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {
           
            emailVerificationEvent(this, EventArgs.Empty);

        }
    }
}
