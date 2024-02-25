using Mooda.Api.Registration;
using System.Threading.Tasks;

namespace Mooda.Infrastructure.Repositories.Customer
{
    public interface ICustomerRepository
    {
        Task<RegisterCustomerEntity> GetCustomer(int customerId);
        Task InsertCustomer(RegisterCustomerEntity registerCustomerEntity);
        Task DeleteCustomer(RegisterCustomerEntity customerEntity);
    }
}
