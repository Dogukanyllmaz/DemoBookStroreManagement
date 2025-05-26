using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBookStroreManagement.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishedDate { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public int StockCount { get; set; }
        public bool IsAvailable { get; set; }

        public Author? Author { get; set; }
        public Publisher? Publisher { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
