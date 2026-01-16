using Microsoft.AspNetCore.Mvc;
using caseStudy.RoomBooking.Domain.Entities;
using caseStudy.RoomBooking.Domain.Repositories;
using System.ComponentModel.DataAnnotations;



namespace caseStudy.RoomBooking.Presentation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly IRepository<User> _userRepository;

        public UsersController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }


        // GET: api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userRepository.GetAll();
            return Ok(users);
        }

    }
}