using LibraryApp.Infrastructure.DTOs.Request_DTO;
using LibraryApp.Infrastructure.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLibraryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IBook _search;
        public SearchController(IBook search)
        {
            _search = search;
        }

        // GET: api/<BookController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> SearchBook(string model)
        {
            try
            {
                var searched = await _search.SearchBook(model);
                return Ok(searched);

            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
