namespace TwitterSystem.Web.ViewModels.User
{
    using Infrastructure.Mapping;
    using TwitterSystem.Models;

    public class UserViewModel : IMapFrom<User>
    {
        public string UserName { get; set; }

        public bool IsCurrentUser { get; set; }

        public bool IsFollowedByCurrentUser { get; set; }
    }
}
