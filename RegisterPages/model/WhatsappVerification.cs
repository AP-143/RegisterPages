using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPages.model
{
    internal class WhatsappVerification
    {
        public event EventHandler waVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {
           
            waVerificationEvent(this, EventArgs.Empty);

        }
    }
}
