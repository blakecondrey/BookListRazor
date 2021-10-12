using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Author { get; set; }
    }
}