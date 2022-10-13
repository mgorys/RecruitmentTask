
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TaskMG.Models.DTOs
{
	public class SentenceDto
	{
        [Display(Name = "Input Sentence")]
        public string InputSentence { get; set; }
        [Display(Name = "Reversed Sentence")]
        public string? OutputSentence { get; set; }
        public bool IsSaved { get; set; }
        public string ErrorMessage { get; set; }
    }
}
