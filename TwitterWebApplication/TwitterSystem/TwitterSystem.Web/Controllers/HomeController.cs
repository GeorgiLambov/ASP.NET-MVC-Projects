namespace TwitterSystem.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Contracts;
    using ViewModels;
    using ViewModels.Tweets;

    public class HomeController : BaseController
    {
        private const int pageSize = 10;

        public HomeController(ITweeterData data)
            : base(data)
        {
        }

        public ActionResult Index(int page = 1)
        {
            
            //if (this.User.IsLoggedIn())
            //{
                
            //}

            var totalPages = (int)Math.Ceiling(this.Data.Tweets.All().Count() / (decimal)pageSize);
            var latestTweets = this.Data.Tweets
                .All()
                .OrderByDescending(t => t.DateOfCreate)
                .Skip(pageSize * (page - 1))
                .Take(pageSize)
                .Project()
                .To<TweetViewModel>();

            var homeViewModel = new HomeViewModel
            {
                Tweets = latestTweets,
                PaginationModel = new PaginationViewModel
                {
                    CurrentPage = page,
                    TotalPages = totalPages
                }
            };

            return this.View(homeViewModel);
        }
    }
}