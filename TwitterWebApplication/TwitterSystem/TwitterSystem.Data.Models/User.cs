namespace TwitterSystem.Data.Models
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {
        private ICollection<User> followers;
        private ICollection<User> followings;
        private ICollection<Tweet> tweets;
        private ICollection<Notification> notifications;
        private ICollection<Tweet> retweetTweets;
        private ICollection<Tweet> favouriteTweets;
        private ICollection<Replay> replays;
        private ICollection<Report> reports;

        public User()
        {
            this.followers = new HashSet<User>();
            this.followings = new HashSet<User>();
            this.tweets = new HashSet<Tweet>();
            this.notifications = new HashSet<Notification>();
            this.retweetTweets = new HashSet<Tweet>();
            this.favouriteTweets = new HashSet<Tweet>();
            this.replays = new HashSet<Replay>();
            this.reports = new HashSet<Report>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string FullName { get; set; }

        public virtual ICollection<User> Followers
        {
            get { return this.followers; }
            set { this.followers = value; }
        }

        public virtual ICollection<User> Followings
        {
            get { return this.followers; }
            set { this.followings = value; }
        }

        public virtual ICollection<Tweet> Tweets
        {
            get { return this.tweets; }
            set { this.tweets = value; }
        }

        public virtual ICollection<Notification> Notifications
        {
            get { return this.notifications; }
            set { this.notifications = value; }
        }

        public virtual ICollection<Tweet> RetweetTweets
        {
            get { return this.retweetTweets; }
            set { this.retweetTweets = value; }
        }

        public virtual ICollection<Tweet> FavouriteTweets
        {
            get { return this.favouriteTweets; }
            set { this.favouriteTweets = value; }
        }

        public virtual ICollection<Replay> Replays
        {
            get { return this.replays; }
            set { this.replays = value; }
        }

        public virtual ICollection<Report> Reports
        {
            get { return this.reports; }
            set { this.reports = value; }
        }

    }
}
