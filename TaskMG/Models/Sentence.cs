using System.ComponentModel.DataAnnotations;

namespace TaskMG.Models
{
    public class Sentence
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Input Sentence")]
        public string InputSentence { get; set; }
        [Display(Name = "Reversed Sentence")]
        public string? OutputSentence { get; set; }
    }
}
