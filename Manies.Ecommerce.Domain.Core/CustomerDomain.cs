using Manies.Ecommerce.Domain.Entity;
using Manies.Ecommerce.Domain.Interface;
using Manies.Ecommerce.Infrastructure.Interface;

namespace Manies.Ecommerce.Domain.Core
{
    public class CustomerDomain : ICustomerDomain
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            return await _unitOfWork.Customers.DeleteAsync(customerId);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _unitOfWork.Customers.GetAllAsync();
        }

        public async Task<Customer> GetAsync(string customerId)
        {
            return await _unitOfWork.Customers.GetAsync(customerId);
        }

        public async Task<bool> InsertAsync(Customer customer)
        {
            return await _unitOfWork.Customers.InsertAsync(customer);
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            return await _unitOfWork.Customers.UpdateAsync(customer);
        }
    }
}
