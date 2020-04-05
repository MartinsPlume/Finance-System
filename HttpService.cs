using System;
using System.Net.Http;
using System.Threading.Tasks;
using FinanceSystem.models;

namespace FinanceSystem
{
    public static class HttpService
    {
        private static readonly HttpClient Client = new HttpClient();

        public static async Task<Uri> CreateProductAsync(Product product)
        {
            Client.BaseAddress = new Uri("https://localhost:44361/");
            var response = await Client.PostAsJsonAsync(
                "api/product", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
        
        public static async Task<Product> UpdateProductAsync(Product product)
        {
            Client.BaseAddress = new Uri("https://localhost:44361/");
            HttpResponseMessage response = await Client.PutAsJsonAsync(
                $"api/product/{product.ProductId}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }
        
    }
}