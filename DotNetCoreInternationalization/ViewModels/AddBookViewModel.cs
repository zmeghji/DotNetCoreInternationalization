using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreInternationalization.ViewModels
{
    public class AddBookViewModel
    {
        [Display(Name ="TitleFieldLabel")]
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
    }
}
