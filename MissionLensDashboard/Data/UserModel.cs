namespace MissionLensDashboard.Data
{
    public class UserModel
    {
        public string UserType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Title { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Status { get; set; } = "";
        public DateTime LastLogin { get; set; }
    }
}
