using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using MarketingBox.Sdk.Common.Extensions;
using MarketingBox.UserApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MarketingBox.UserApi.Controllers
{
    [ApiController]
    [Authorize]
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
        [HttpPost("resetPassword")]

        public async Task<IActionResult> LoginAsync(
            [FromBody] ResetPasswordRequestHttp request)
        {
            request.ValidateEntity();
            await Task.CompletedTask;
            return Ok();
        }
    }
}