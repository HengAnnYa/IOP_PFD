using System.ComponentModel.DataAnnotations;

namespace InsightOpticPro_PFD_Final.Models
{
    public class Questions
    {
        [Required]
        [Display(Name = "Question Id")]
        public int QuestionsId { get; set; }

        public string Question { get; set; }

        public string Category { get; set; }

        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

    }
}
