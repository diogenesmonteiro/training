using System;
using System.Threading.Tasks;
using Mooda.Api;
using Mooda.Api.Filters;
using Mooda.Application.Registration;
using Microsoft.AspNetCore.Mvc;
using Mooda.Api.Registration;

namespace Mooda.Api.CustomerRegistration
{
    [Route("~/registration")]
    [ApiController]
    [ApiKeyAuthorization]
    public class CustomerController : ApiControllerBase
    {
        ICustomerRegistrationService _customerRegistrationService;

        public CustomerController(ICustomerRegistrationService customerRegistrationService)
        {
        }

       
    }
}