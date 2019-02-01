using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabService
{
    class CCredentialsValidator : UserNamePasswordValidator 
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
                throw new ArgumentNullException();
            //TODO: Add DB Validation
        }
    }
}
