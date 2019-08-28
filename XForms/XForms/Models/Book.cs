using System;
using System.Collections.Generic;
using System.Text;

namespace XForms.Models
{
    public class Book
    {
        public Int64 Id { get; set; }

        public string BookTitle { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public float Price { get; set; }

        public Int64 AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
