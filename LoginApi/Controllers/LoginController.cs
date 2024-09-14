using LoginApi.DTO;
using LoginApi.Entities;
using LoginApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LoginApi.Controllers
{
    [ApiController]
    [Route("Api/Login")]
    public class LoginController : ControllerBase
    {
        private readonly IValidateUserRepository _userRepository;
        public LoginController(IValidateUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        [HttpPost("ValidateUser")]
        public async Task<IActionResult> ValidateUser([FromBody]UsersDTO user) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Data dont correspond with the actual model");
            }
            
            return Ok(await _userRepository.VerifyUser(new Users 
            {
                UserName = user.UserName,
                Password = user.Password
            }));
        }
    }
}
