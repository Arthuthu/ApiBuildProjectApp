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
        public IActionResult Post([FromBody] UserModel user)
        {
            _userRepository.Create(user);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel user)
        {
            _userRepository.Update(id, user);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userRepository.Delete(id);

            return Ok();
        }
    }
}
