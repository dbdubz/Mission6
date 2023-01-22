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
        string Category;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required")]
        string Title;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Year is required")]
        string Year;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Director is required")]
        string Director;

        bool Edited;

        string LentTo;

        [StringLength(25)]
        string Notes;
    }
}
