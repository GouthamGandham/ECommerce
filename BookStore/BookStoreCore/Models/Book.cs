using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace BookStore.Models
{
    [Bind(Exclude = "BookId")]
    public class Book
    {
        [ScaffoldColumn(false)]
        public int BookId { get; set; }

        [DisplayName("Genre")]
        public int GenreId { get; set; }

        [DisplayName("Author")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "An Book Title is required")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }

        [DisplayName("Book Art URL")]
        [StringLength(1024)]
        public string BookArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}