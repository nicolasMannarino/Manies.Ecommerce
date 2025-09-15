using Manies.Ecommerce.Domain.Entity;

namespace Manies.Ecommerce.Domain.Interface
{
    public interface ICustomerDomain
    {
        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(Customer customerId);
        Task<Customer> GetAsync(Customer customerId);
        Task<IEnumerable<Customer>> GetAllAsync();



    }
}
