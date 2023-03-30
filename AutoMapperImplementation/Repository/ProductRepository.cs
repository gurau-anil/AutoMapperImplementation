using Microsoft.EntityFrameworkCore;
using AutoMapperImplementation.Repositories.Interfaces;
using AutoMapperImplementation.Entities;
using AutoMapperImplementation.Data;

namespace AutoMapperImplementation.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _dbContext.Product.ToListAsync();
            return result;
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
