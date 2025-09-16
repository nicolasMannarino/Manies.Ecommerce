using Manies.Ecommerce.Infrastructure.Interface;

namespace Manies.Ecommerce.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomerRepository Customers { get; }

        public UnitOfWork(ICustomerRepository customers) 
        { 
            Customers = customers;
        }
        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}
