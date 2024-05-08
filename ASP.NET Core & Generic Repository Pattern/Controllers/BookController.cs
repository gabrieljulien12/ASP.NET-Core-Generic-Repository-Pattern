using ASP.NET_Core___Generic_Repository_Pattern.Models.Entities;
using ASP.NET_Core___Generic_Repository_Pattern.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ASP.NET_Core___Generic_Repository_Pattern.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository repository)
        {
            _bookRepository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var books = _bookRepository.GetAll();
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            if (ModelState.IsValid)
            {
                await _bookRepository.Create(book);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
       
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            var existingBook = await _bookRepository.GetById(id);

            if (existingBook == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _bookRepository.Uptade(id, book);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existingBook = await _bookRepository.GetById(id);

            if (existingBook == null)
            {
                return NotFound();
            }

            await _bookRepository.Delete(id);
            return Ok();
        }

        [HttpGet("firstname")]
        public async Task<IActionResult> GetFirstName()
        {
            var firstName = await _bookRepository.GetFirstName();
            return Ok(firstName);
        }

    }
}