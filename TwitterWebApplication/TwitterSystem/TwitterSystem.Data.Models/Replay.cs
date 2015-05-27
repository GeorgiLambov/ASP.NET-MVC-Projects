namespace TwitterSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Replay
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public User Author { get; set; }

        [Required]
        public int TweetId { get; set; }

        [ForeignKey("TweetId")]
        public virtual Tweet Tweet { get; set; }
    }
}