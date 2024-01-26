using System.ComponentModel.DataAnnotations;

namespace InsightOpticPro_PFD_Final.Models
{
    public class Category
    {
        [Required]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; } 

        public string CategoryName { get; set; }
    }
}
