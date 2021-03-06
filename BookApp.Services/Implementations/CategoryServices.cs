using BookApp.Model.Context;
using BookApp.Model.Entities;
using BookApp.Services.Interfaces;
using BookApp.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Services.Implementations
{
    public class CategoryServices : BaseRepository<Category>, ICategoryServices
    {
        public CategoryServices(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
