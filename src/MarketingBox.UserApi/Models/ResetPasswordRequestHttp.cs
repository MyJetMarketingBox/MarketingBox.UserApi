using System.ComponentModel.DataAnnotations;
using MarketingBox.Sdk.Common.Attributes;
using MarketingBox.Sdk.Common.Models;

namespace MarketingBox.UserApi.Models
{
    public class ResetPasswordRequestHttp : ValidatableEntity
    {
        [Required, IsValidPassword]
        public string OldPassword { get; set; }
        
        [Required, IsValidPassword]
        public string NewPassword { get; set; }
    }
}