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

        // todo: remove when role management will be implemented
        private const long Admin = 999;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        [HttpPut("password")]
        public async Task<IActionResult> LoginAsync(
            [FromBody] ChangePasswordRequestHttp request)
        {
            try
            {
                request.ValidateEntity();
                var currentUserId = this.GetUserId();
                if (request.UserId.HasValue && currentUserId != Admin)
                {
                    throw new ForbiddenException(
                        "Current user can't change password for someone else, except himself.");
                }

                var requestGrpc = new ChangePasswordRequest
                {
                    NewPassword = request.NewPassword,
                    UserId = request.UserId ?? currentUserId,
                    TenantId = this.GetTenantId(),
                    ChangedByUserId = currentUserId
                };
                var response = await _userService.ChangePasswordAsync(requestGrpc);
                return this.ProcessResult(response);
            }
            catch (Exception e)
            {
                return e.Failed();
            }
        }
    }
}