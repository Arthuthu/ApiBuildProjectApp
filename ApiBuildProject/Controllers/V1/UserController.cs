using ApiBuildProject.Contracts.V1;
using ApiBuildProject.Models;
using ApiBuildProject.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace ApiBuildProject.Controllers.V1
{
    [Route(ApiRoutes.Users.Route)]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userRepository.GetAllUser();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public UserModel GetById(int id)
        {
            var user = _userRepository.GetById(id);

            return user;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
