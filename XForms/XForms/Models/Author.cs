using System;
using System.Collections.Generic;
using System.Text;

namespace XForms.Models
{
    public class Author
    {
        public Int64 Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public string Email { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
