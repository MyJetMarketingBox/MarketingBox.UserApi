using System.ComponentModel.DataAnnotations;
using MarketingBox.Sdk.Common.Models;

namespace MarketingBox.UserApi.Models
{
    public class ResetPasswordRequestHttp : ValidatableEntity
    {
        [Required, StringLength(128,MinimumLength = 1)]
        public string OldPassword { get; set; }
        
        [Required, StringLength(128,MinimumLength = 1)]
        public string NewPassword { get; set; }
    }
}