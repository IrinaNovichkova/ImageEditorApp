using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LabService
{
    [ServiceContract]
    public interface ILabRegistrationService
    {
        [OperationContract]
        Boolean Register(String login, String password);
    }
}
