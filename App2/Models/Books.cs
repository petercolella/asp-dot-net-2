using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required, StringLength(64, MinimumLength = 4)]
        public string Title { get; set; }

        [Required, StringLength(64, MinimumLength = 4)]
        public string Genre { get; set; }

        [Display(Name = "Publication Date")]
        [Required, DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
    }
}
