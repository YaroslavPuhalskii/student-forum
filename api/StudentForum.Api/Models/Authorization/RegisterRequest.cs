using System.ComponentModel.DataAnnotations;

namespace StudentForum.Api.Models.Authorization
{
    public class RegisterRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Length from 1 to 50")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Length from 1 to 50")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Length from 1 to 50")]
        public string Email { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Length from 1 to 255")]
        public string Password { get; set; }
    }
}
