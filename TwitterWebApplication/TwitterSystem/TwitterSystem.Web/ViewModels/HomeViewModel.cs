namespace TwitterSystem.Web.ViewModels
{
    using System.Collections.Generic;
    using Tweets;

    public class HomeViewModel
    {
        public IEnumerable<TweetViewModel> Tweets { get; set; }

        public PaginationViewModel PaginationModel { get; set; }
    }
}