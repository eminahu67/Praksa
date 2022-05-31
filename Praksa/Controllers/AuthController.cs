using System.Threading.Tasks;
using Praksa.Data;
using Microsoft.AspNetCore.Mvc;
using Praksa.Models;
using Praksa.Dtos.User;


namespace Praksa.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }


        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register (UserRegisterDto request)

        {
            var response = await _authRepo.Register(
                new User { UserName = request.Username },request.Password
                );

            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);


        }








    }
}
