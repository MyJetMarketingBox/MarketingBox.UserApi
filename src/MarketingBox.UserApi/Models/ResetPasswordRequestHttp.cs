using System.ComponentModel.DataAnnotations;

namespace MarketingBox.UserApi.Models
{
    public class ResetPasswordRequestHttp
    {
        [Required, StringLength(128,MinimumLength = 1)]
        public string OldPassword { get; set; }
        
        [Required, StringLength(128,MinimumLength = 1)]
        public string NewPassword { get; set; }
    }
}