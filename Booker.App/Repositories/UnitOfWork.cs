using Booker.App.Context;
using Booker.App.Models;

namespace Booker.App.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookDbContext _context;

        public IRepository<Book> Books { get; }

        public UnitOfWork(BookDbContext context)
        {
            _context = context;
            Books = new Repository<Book>(context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
