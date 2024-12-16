using Booker.App.Models;
using Booker.App.Repositories;

namespace Booker.App.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _unitOfWork.Books.GetAllAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _unitOfWork.Books.GetByIdAsync(id);
        }

        public async Task AddBookAsync(Book book)
        {
            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _unitOfWork.Books.Update(book);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(id);
            if (book != null)
            {
                _unitOfWork.Books.Delete(book);
                await _unitOfWork.CompleteAsync();
            }
        }
    }
}
