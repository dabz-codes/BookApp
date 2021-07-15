using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Model.Entities
{
    public class Category
    {
        public Category()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string  CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public virtual ICollection<Book> Books  { get; set; }


    }
}
