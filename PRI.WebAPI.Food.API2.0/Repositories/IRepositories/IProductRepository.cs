using PRI.WebAPI.Food.API2._0.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PRI.WebAPI.Food.API2._0.Repositories.IRepositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetByCategoryIdAsync(Guid id);
        Task<IEnumerable<Product>> SearchAsync(string search);

    }
}
