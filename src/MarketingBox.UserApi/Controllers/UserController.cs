using System.Threading.Tasks;
using MarketingBox.UserApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingBox.UserApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        [HttpPost("{userId}/resetPassword")]

        public async Task<IActionResult> LoginAsync(
            [FromBody] ResetPasswordRequestHttp request)
        {
            return Ok();
        }
    }
}