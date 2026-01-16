using Microsoft.AspNetCore.Mvc;
using caseStudy.RoomBooking.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace caseStudy.RoomBooking.Presentation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return new List<User>{
                new User { Id = Guid.NewGuid().ToString(), Firstname = "Alice", Lastname = "Smith", Email="alice.smith@example.com" },
                new User { Id = Guid.NewGuid().ToString(), Firstname = "Bob", Lastname = "Johnson", Email="bob.johnson@example.com" }
            };
        }

    }
}