using Entities.Models;
using Server.Paging;
using Entities.RequestFeatures;

namespace BlazorProducts.Server.Repository
{
    public interface IProductRepository
    {
        Task<PagedList<Product>> GetProducts(ProductParameters productParameters);
        Task<Product> GetProduct(Guid id);
        Task CreateProduct(Product product);
    }
}
