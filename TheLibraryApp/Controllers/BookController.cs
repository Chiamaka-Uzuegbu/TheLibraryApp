using LibraryApp.Infrastructure.DTOs.Request_DTO;
using LibraryApp.Infrastructure.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheLibraryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _book;

        public BookController(IBook book)
        {
            this._book = book;
        }
        // GET: api/<BookController>
        [HttpGet]
        public async   Task< ActionResult<IEnumerable<BookDTO> >>GetListOfBookSortedByPublisherDate()
        {
            try
            {
                var listOfBook=  await _book.listOfBooks();
                return Ok(listOfBook);

            }
            catch (Exception)
            {

                return;
            }
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
