using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPages.Controller
{
    internal class MainWindowController
    {
        RegisterUser registerUser;
        EmailVerification emailVerification;
        WhatsappVerification whatsappVerification;
        public MainWindowController()
        {

            registerUser = new RegisterUser();
            emailVerification = new EmailVerification();
            whatsappVerification = new WhatsappVerification();
        }
        public void registeringUser(String name, String email, String phoneNumber)
        {
            registerUser.RegisterAUser();
        }
        public void SubscribeEmailVerification()
        {
            registerUser.registerUserEvent += emailVerification.OnUserRegistered;
        }
        public void UnsubscribeEmailVerification()
        {
            registerUser.registerUserEvent -= emailVerification.OnUserRegistered;
        }
        public void SubscribeWAVerification()
        {
            registerUser.registerUserEvent += whatsappVerification.OnUserRegistered;

        }
        public void UnsubscribeWAVerification()
        {
            registerUser.registerUserEvent -= whatsappVerification.OnUserRegistered;

        }

        public void SubcribeVerificationResult(VerificationResponse listener)
        {
            whatsappVerification.waVerificationEvent += listener.OnWaVerificationSucceed;
            emailVerification.emailVerificationEvent += listener.OnEmailVerificationSucceed;
        }

    }
}
