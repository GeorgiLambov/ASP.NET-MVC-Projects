namespace TwitterSystem.Web.ViewModels.User
{
    using System.Collections.Generic;
    using Tweets;

    public class UserHomeViewModel
    {
        public IEnumerable<TweetViewModel> Tweets { get; set; }

        public PaginationViewModel PaginationModel { get; set; }
    }
}
