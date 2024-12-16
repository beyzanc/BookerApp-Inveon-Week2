using Booker.App.Models;

namespace Booker.App.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Book> Books { get; }
        Task<int> CompleteAsync(); 
    }
}
