using LibraryApp.Infrastructure.DTOs.Request_DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Infrastructure.Repository.IRepository
{
    public interface IBook
    {
        Task<IEnumerable<BookDTO>> listOfBooks();
        Task<IEnumerable<BookDTO>> SearchBook(string model);


    }
}
