namespace Manies.Ecommerce.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
    }
}
