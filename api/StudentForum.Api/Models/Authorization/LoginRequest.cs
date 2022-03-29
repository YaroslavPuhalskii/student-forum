using System.ComponentModel.DataAnnotations;

namespace StudentForum.Api.Models.Authorization
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Length from 1 to 255")]
        public string Password { get; set; }
    }
}
