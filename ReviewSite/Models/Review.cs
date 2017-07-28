using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name = "Title")]
        public string ReviewTitle { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime ReviewDate { get; set; }
        [Display(Name = "Review")]
        public string ReviewContent { get; set; }
        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }

        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}