using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBookStroreManagement.Domain.Entities
{
    public class Publisher:BaseEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
        public string? Phone { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
