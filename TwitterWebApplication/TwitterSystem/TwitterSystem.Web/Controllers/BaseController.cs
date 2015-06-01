namespace TwitterSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Data.Contracts;
    using Data.Models;
    using Microsoft.AspNet.Identity;
    using ViewModels.Alerts;

    public abstract class BaseController : Controller
    {
        private ITweeterData data;
        private User userProfile;

        protected BaseController(ITweeterData data)
        {
            this.Data = data;
        }

        protected BaseController(ITweeterData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }

        protected User  UserProfile {
            get { return this.userProfile; }
            private set { this.userProfile = value; } 
        }

        public ITweeterData Data
        {
            get { return this.data; }
            private set { this.data = value; }
        }
        
        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.GetUserName();
                var user = this.Data
                    .Users
                    .All()
                    .Include(u => u.FavouriteTweets)
                    .Include(u => u.Followers)
                    .Include(u => u.Following)
                    .Include(u => u.Notifications)
                    .Include(u => u.ReceivedMessages)
                    .Include(u => u.ReportsSent)
                    .Include(u => u.Tweets)
                    .FirstOrDefault(u => u.UserName == username);
                this.UserProfile = user;
                this.ViewBag.UserProfile = user;
            }

            return base.BeginExecute(requestContext, callback, state);
        }

        protected void AddAlert(string message, AlertType type)
        {
            if (this.TempData["alerts"] == null)
            {
                this.TempData["alerts"] = new HashSet<AlertViewModel>();
            }

            ((HashSet<AlertViewModel>)this.TempData["alerts"]).Add(new AlertViewModel(message, type));
        }
    }
}