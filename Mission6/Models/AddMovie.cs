using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class AddMovie
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Category is required")]
        public string Category;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required")]
        public string Title;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Year is required")]
        public string Year;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Director is required")]
        public string Director;

        public bool Edited;

        public string LentTo;

        [StringLength(25)]
        public string Notes;
    }
}
