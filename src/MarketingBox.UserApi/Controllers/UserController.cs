using System;
using System.Threading.Tasks;
using MarketingBox.Auth.Service.Grpc;
using MarketingBox.Auth.Service.Grpc.Models;
using MarketingBox.Sdk.Common.Exceptions;
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
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPut("password")]
        public async Task<IActionResult> LoginAsync(
            [FromBody] ChangePasswordRequestHttp request)
        {
            if (request is null)
                throw new BadRequestException("Invalid request format");
            request.ValidateEntity();
            var currentUserId = this.GetUserId();
            var requestGrpc = new ChangePasswordRequest
            {
                OldPassword = request.OldPassword,
                NewPassword = request.NewPassword,
                UserId = currentUserId,
                TenantId = this.GetTenantId()
            };
            var response = await _userService.ChangePasswordAsync(requestGrpc);
            return this.ProcessResult(response);
        }
    }
}