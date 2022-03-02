using Microsoft.EntityFrameworkCore;
using PRI.WebAPI.Food.API2._0.Data;
using PRI.WebAPI.Food.API2._0.Entities;
using PRI.WebAPI.Food.API2._0.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRI.WebAPI.Food.API2._0.Repositories.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        public ProductRepository(ApplicationDbContext dbContext, ApplicationDbContext applicationDbContext) : base(dbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public override IQueryable<Product> GetAll()
        {
            return _dbContext.Products.Include(p => p.Category);
        }

        public async override Task<IEnumerable<Product>> ListAllAsync()
        {
            var products = await GetAll().ToListAsync();
            return products;
        }

        public async override Task<Product> GetByIdAsync(Guid id)
        {
            var product = await GetAll().SingleOrDefaultAsync(p => p.Id.Equals(id));
            return product;
        }

        public async Task<IEnumerable<Product>> GetByCategoryIdAsync(Guid id)
        {
            var products = await GetAll().Where(p => p.CategoryId.Equals(id)).ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> SearchAsync(string search)
        {
            var products = await GetAll()
                .Where(p => p.Name.Contains(search.Trim().ToUpper()) || p.Category.Name.Contains(search.Trim().ToUpper()))
                .ToListAsync();

            return products;
        }
    }
}
