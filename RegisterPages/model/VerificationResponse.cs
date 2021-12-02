using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPages.model
{
    internal class VerificationResponse
    {
        public void OnWaVerificationSucceed(object source, EventArgs e);
        public void OnEmailVerificationSucceed(object source, EventArgs e);
    }
}
