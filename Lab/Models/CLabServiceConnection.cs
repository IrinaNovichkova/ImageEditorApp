using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.ServiceModel;
using Lab.LabServiceReference;
using System.ServiceModel.Security;

namespace Lab
{
    internal class CLabServiceConnection
    {
        private LabServiceClient _client;

        public CLabServiceConnection()
        {
            _client = new LabServiceClient("WSHttpBinding_ILabService");
            _client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
        }

        public EAuthenticationStatus Authenticate(String login, SecureString password)
        {
            try
            {
                _client.ClientCredentials.UserName.UserName = login;
                _client.ClientCredentials.UserName.Password = SEncryptor.GetSHA256Hash(password);
                _client.GetCurrentUser();
            }
            catch(Exception e) //TODO: Add exception handling
            {

            }

            return EAuthenticationStatus.Authenticated;
        }



        


    }
}
