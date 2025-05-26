using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBookStroreManagement.Application.DTOs
{
    public class BookDetailsDto : IDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public string? AuthorFullName { get; set; }
        public string? PublisherName { get; set; }
        public DateTime PublishedDate { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        public int StockCount { get; set; }
        public bool IsAvaliable { get; set; }
        public List<string> Categories { get; set; }
    }
}
