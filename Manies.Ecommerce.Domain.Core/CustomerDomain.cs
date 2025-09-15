using Manies.Ecommerce.Domain.Entity;
using Manies.Ecommerce.Domain.Interface;

namespace Manies.Ecommerce.Domain.Core
{
    public class CustomerDomain : ICustomerDomain
    {
        public Task<bool> DeleteAsync(Customer customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(Customer customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
