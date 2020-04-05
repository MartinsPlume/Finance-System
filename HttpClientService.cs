using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FinanceSystem.models;

namespace FinanceSystem
{
    public static class HttpClientService
    {
        private static readonly HttpClient Client = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:44361/")
        };

        private static HttpResponseMessage _response;

        public static async Task CreateProductAsync(Product product)
        {
            
            _response = await Client.PostAsJsonAsync(
                "api/product", product);
            _response.EnsureSuccessStatusCode();

            // return URI of the created resource.
        }
        
        public static IEnumerable<Product> GetProductData()
        {
            _response = Client.GetAsync("api/product").Result;
            return _response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
        }
        
        public static async Task UpdateProductAsync(Product product)
        {
            _response = await Client.PutAsJsonAsync(
                $"api/product/{product.ProductId}", product);
            _response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            await _response.Content.ReadAsAsync<Product>();
        }

        public static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            _response = await Client.DeleteAsync(
                $"api/product/{id}");
            return _response.StatusCode;
        }

        public static IEnumerable<Order> GetOrderData()
        {
            _response = Client.GetAsync("api/order").Result;
            return _response.Content.ReadAsAsync<IEnumerable<Order>>().Result;
        }

        public static async Task UpdateOrderAsync(Order oldOrder)
        {
            var order = new Order
            {
                OrderId = oldOrder.OrderId,
                Name = oldOrder.Name,
                Email = oldOrder.Email,
                PostalCode = oldOrder.PostalCode,
                Status = "Invoiced",
                ProductId = oldOrder.ProductId
            };

            _response = await Client.PutAsJsonAsync(
                $"api/order/{oldOrder.OrderId}", order);
            _response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            await _response.Content.ReadAsAsync<Order>();
        }
    }
}