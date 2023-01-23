using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Year is required")]
        public string Year { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Director is required")]
        public string Director { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }
    }
}
