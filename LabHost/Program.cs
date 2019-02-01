using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using LabService;

namespace LabHost
{
    class Program
    {
        static void Main(string[] args)
        {   
            Uri address = new Uri(@"http://localhost:8000/Lab");
            using (var host = new ServiceHost(typeof(LabService.LabService)))
            {
                //host.AddServiceEndpoint(typeof(ILabService), new WSHttpBinding("LabServiceBinding"), "LabService");
                //host.AddServiceEndpoint(typeof(ILabRegistrationService), new WSHttpBinding("LabRegistrationServiceBinding"), "LabRegistrationService");

                host.Open();
                Console.WriteLine("Host started");
                Console.WriteLine("Press enter to stop service");
                Console.ReadLine();
            }
        }
    }
}
