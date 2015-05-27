namespace TwitterSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Tweet
    {
        private ICollection<User> usersFavorites;
        private ICollection<User> usersReTweets;
        private ICollection<Report> reports;
        private ICollection<Replay> replays;

        public Tweet()
        {
            this.CreateOn = DateTime.Now;
            this.usersFavorites = new HashSet<User>();
            this.usersReTweets = new HashSet<User>();
            this.reports = new HashSet<Report>();
            this.replays = new HashSet<Replay>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime CreateOn { get; set; }

        public virtual ICollection<User> UsersFavorites
        {
            get { return this.usersFavorites; }
            set { this.usersFavorites = value; }
        }

        public virtual ICollection<User> UsersReTweets
        {
            get { return this.usersReTweets; }
            set { this.usersReTweets = value; }
        }

        public virtual ICollection<Report> Reports
        {
            get { return this.reports; }
            set { this.reports = value; }
        }

        public virtual ICollection<Replay> Replays
        {
            get { return this.replays; }
            set { this.replays = value; }
        }
    }
}
