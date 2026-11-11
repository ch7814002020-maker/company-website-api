using CompanyWebsite.Api.Data;
using CompanyWebsite.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebsite.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactMessagesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactMessagesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactMessage contactMessage)
        {
            _context.ContactMessages.Add(contactMessage);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Your message has been saved successfully!"
            });
        }
    }
}