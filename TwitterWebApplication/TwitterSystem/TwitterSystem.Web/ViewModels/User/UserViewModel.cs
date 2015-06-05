namespace TwitterSystem.Web.ViewModels.User
{
    using TwitterSystem.Models;
    using Twitter.Web.Infrastructure.Mapping;

    public class UserViewModel : IMapFrom<User>
    {
        public string UserName { get; set; }

        public bool IsCurrentUser { get; set; }

        public bool IsFollowedByCurrentUser { get; set; }
    }
}
