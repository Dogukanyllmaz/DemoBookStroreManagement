﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBookStroreManagement.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Nationality { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
