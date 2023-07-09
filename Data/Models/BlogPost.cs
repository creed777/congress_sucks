using System.ComponentModel.DataAnnotations;

namespace congress_sucks.Data.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = String.Empty;
        [Required]
        public string Post { get; set; } = String.Empty ;
        [Required]
        public string Tags { get; set; } = string.Empty;
        [Required]
        public DateTime Updated { get; set; }
    }
}
