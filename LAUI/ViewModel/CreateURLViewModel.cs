using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAUI.ViewModel
{
    public class CreateURLViewModel
    {
        [Required]
        public string UrlTitle { get; set; }

        [Required]
        [Display(Name ="URL")]
        public string LAUrlName { get; set; }

        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
