using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Entities.Models;

namespace Client.HttpRepository
{
    public class ProductHttpRepository : IProductHttpRepository
    {
        private readonly HttpClient _client;
        public ProductHttpRepository( HttpClient client)
        {
            _client = client;
        }

        public async Task CreateProduct(Product product)
        {
            await _client.PutAsJsonAsync("products", product);
        }

        public async Task<Product> GetProduct(Guid id)
        {
            var product = await _client.GetFromJsonAsync<Product>($"products/{id}");
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await _client.GetFromJsonAsync<List<Product>>("products");
            return products;
        }
    }
}