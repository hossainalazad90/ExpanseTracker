using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseTracker.Context
{
    public class Expanse
    {
        public int Id { get; set; }
        [Display(Name ="Category")]
        [Required]
        public int ExpanseCategoryId { get; set; }
        [Display(Name = "Date")]
        [Required]
        [DataType(DataType.Date)]       
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        
        public DateTime EntryDate { get; set; }
        [Display(Name = "Amount")]
        public decimal ExpanseAmount { get; set; }
        public string Details { get; set; }

        [ForeignKey("ExpanseCategoryId")]
        [Display(Name = "Category")]
        public virtual ExpanseCategory ExpanseCategory { get; set; }
    }
}
