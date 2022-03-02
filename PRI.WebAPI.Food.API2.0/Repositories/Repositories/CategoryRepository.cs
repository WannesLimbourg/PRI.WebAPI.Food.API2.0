using PRI.WebAPI.Food.API2._0.Data;
using PRI.WebAPI.Food.API2._0.Entities;
using PRI.WebAPI.Food.API2._0.Repositories.IRepositories;

namespace PRI.WebAPI.Food.API2._0.Repositories.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
