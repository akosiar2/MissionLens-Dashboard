using System.ComponentModel.DataAnnotations;

namespace MissionLensDashboard.Data
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
    
}
