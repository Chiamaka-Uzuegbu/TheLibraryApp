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
using LibraryApp.Core.Entities;

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
        public async Task<IEnumerable<BookDTO>> listOfBooks()
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

        public async Task<IEnumerable<BookDTO>> SearchBook(string model)
        {
           
            if (_dbContext.BookDetails.Any(b => b.ISBN.Contains(model)))
            {
                var searchByISBN = await _dbContext.BookDetails.Where(s => s.ISBN.Contains(model)).ToListAsync();
                return _mapper.Map<IEnumerable<BookDTO>>(searchByISBN);


            }
            else if (_dbContext.BookDetails.Any(b => b.Title.Contains(model)))
            {
                var searchByTitle = await _dbContext.BookDetails.Where(s => s.Title.StartsWith(model)).ToListAsync();
                return _mapper.Map<IEnumerable<BookDTO>>(searchByTitle);


            }
            else
            {

                var searchByAvailabilityStatus = await _dbContext.BookDetails.Where(s => s.AvailabilityStatus == true).ToListAsync();
                return _mapper.Map<IEnumerable<BookDTO>>(searchByAvailabilityStatus);
            }






           



        }

















    }
}
