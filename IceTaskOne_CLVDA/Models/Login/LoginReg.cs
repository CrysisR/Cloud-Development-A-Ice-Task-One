using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IceTaskOne_CLVDA.Models.Login
{
    public class LoginReg
    {
        [Key]
        public int userId { get; set; }

        [StringLength(8, MinimumLength = 3)]
        [Required]
        [Display(Name = "Username")]
        public string? username { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string? password { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string? tempUser { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string? TempPass { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string? TempConfPass { get; set; }
    }
}
