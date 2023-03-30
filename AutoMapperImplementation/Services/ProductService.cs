using AutoMapperImplementation.Entities;
using AutoMapperImplementation.Repositories.Interfaces;
using AutoMapperImplementation.Services.Interfaces;

namespace AutoMapperImplementation.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<Product> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _productRepository.GetAll();
            return result;
        }

        public Task<Product> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
