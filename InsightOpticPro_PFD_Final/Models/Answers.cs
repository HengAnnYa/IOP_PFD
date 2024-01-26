using System.ComponentModel.DataAnnotations;

namespace InsightOpticPro_PFD_Final.Models
{
    public class Answers
    {
        [Required]
        [Display(Name = "Answer Id")]
        public int AnswerId { get; set; }

        [Display(Name = "Questiom Id")]
        public int QuestionId { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
