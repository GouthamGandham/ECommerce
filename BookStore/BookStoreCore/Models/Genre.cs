using System.Collections.Generic;

namespace BookStore.Models
{
    public partial class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Book { get; set; }
    }
}
