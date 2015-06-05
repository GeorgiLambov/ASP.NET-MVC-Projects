namespace TwitterSystem.Web.ViewModels.User
{
    using System.Collections.Generic;
    using InputModels;
    using Tweets;

    public class UserHomeViewModel
    {
        public IEnumerable<TweetViewModel> Tweets { get; set; }

        public TweetInputModel NewTweet { get; set; }

        public PaginationViewModel PaginationModel { get; set; }
    }
}
