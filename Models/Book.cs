using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Books.Models
{
    public class Book
    {
        public Book()
        {
        }

        [BindNever]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Book name is required.")]
        public string BookName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Author name is required.")]
        public string AuthorName { get; set; }

        [Required]
        [Range(0, 99.99, ErrorMessage = "Price must be between 0 and 99.99")]
        public decimal Price { get; set; }

        [Required]
        [Range(1,5, ErrorMessage = "Publisher must be selected.")]
        public int PublisherId { get; set; }

        [NotMapped]
        public string PublisherName { get; set; }


    }
}
