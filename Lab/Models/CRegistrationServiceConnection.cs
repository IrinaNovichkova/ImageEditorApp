using Lab.LabServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class CRegistrationServiceConnection
    {
        private LabRegistrationServiceClient _registrationClient;
        public CRegistrationServiceConnection()
        {
            _registrationClient = new LabRegistrationServiceClient("WSHttpBinding_ILabRegistrationService");
        }

        public EAuthenticationStatus Register(String login, SecureString password)
        {
            try
            {
                _registrationClient.Register(login, SEncryptor.GetSHA256Hash(password));
            }
            catch(Exception e) //TODO: Add another exception handling
            {
                return EAuthenticationStatus.None;
            }
            return EAuthenticationStatus.Authenticated;
        }
    }
}
