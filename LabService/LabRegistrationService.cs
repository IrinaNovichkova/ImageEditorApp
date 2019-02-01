using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LabService
{
    public partial class LabService : ILabRegistrationService
    {
        public bool Register(string login, string password)
        {
            return true;
        }
    }
}
