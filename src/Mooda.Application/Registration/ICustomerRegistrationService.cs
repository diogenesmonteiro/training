using Mooda.Api.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooda.Application.Registration
{
    public interface ICustomerRegistrationService
    {
        Task Register(RegisterCustomerEntity registerCustomerEntity);
        Task Delete(int userRegistrationId);
    }
}
