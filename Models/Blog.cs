using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [StringLength(100)]
        public string Author { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        [StringLength(500)]
        public string Summary { get; set; } = string.Empty;
    }
}