using MissionLensDashboard.Data;

namespace MissionLensDashboard.Services
{
    public class UserCacheService
    {
        public UserModel CurrentUser { get; private set; }

        public void SetUser(UserModel user)
        {
            CurrentUser = user;
        }

        public void ClearUser()
        {
            CurrentUser = null;
        }
    }
}
