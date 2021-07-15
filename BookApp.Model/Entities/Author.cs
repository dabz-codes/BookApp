using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Model.Entities
{
    public class Author
    {
        public Author()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public string  Address { get; set; }
        public DateTime  CreatedAt { get; set; }
        public string  CreatedBy { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
