using DistributedCaching.DTOs;
using DistributedCaching.Models;

namespace DistributedCaching.Services
{
    public interface IProductService
    {
        public Task Add(ProductCreationDto request);
        public Task<Product> Get(Guid id);
        public Task<List<Product>> GetAll();
    }
}
