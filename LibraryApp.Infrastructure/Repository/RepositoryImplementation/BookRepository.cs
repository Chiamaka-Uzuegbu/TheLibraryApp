using AutoMapper;
using LibraryApp.Infrastructure.DataAccess;
using LibraryApp.Infrastructure.DTOs.Request_DTO;
using LibraryApp.Infrastructure.Repository.IRepository;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Infrastructure.Repository.RepositoryImplementation
{
    public class BookRepository : IBook
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public BookRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }
        public  async Task<IEnumerable<BookDTO>> listOfBooks()
        {
            try
            {
                var listOfBooks = await _dbContext.BookDetails.OrderBy(s => s.PublishYear).ToListAsync();
                    return _mapper.Map<IEnumerable<BookDTO>>(listOfBooks);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
