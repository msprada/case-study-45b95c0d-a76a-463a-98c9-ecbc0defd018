using Microsoft.AspNetCore.Mvc;
using caseStudy.RoomBooking.Domain.Entities;
using caseStudy.RoomBooking.Domain.Repositories;
using System.ComponentModel.DataAnnotations;
using caseStudy.RoomBooking.Application.Abstractions;



namespace caseStudy.RoomBooking.Presentation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly ICore _coreService;

        public UsersController(ICore coreService)
        {
            this._coreService = coreService;
            
        }


        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await this._coreService.UnitOfWork.GetRepository<User>().GetAllAsync();
            return Ok(users);
        }

    }
}