using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Model.Entities
{
    public class Book
    {
        public Book()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearofPublication { get; set; }
        public string Publisher { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public virtual Author Author { get; }
        public virtual Category Category { get; }
    }
}
