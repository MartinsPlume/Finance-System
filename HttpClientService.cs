using System;
using System.Collections.Generic;
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

        public static async Task CreateProductAsync(Product product)
        {
            
            var response = await Client.PostAsJsonAsync(
                "api/product", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
        }

        public static IEnumerable<Product> GetProductData()
        {
            var response = Client.GetAsync("api/product").Result;
            return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
        }
        
        public static async Task UpdateProductAsync(Product product)
        {
            var response = await Client.PutAsJsonAsync(
                $"api/product/{product.ProductId}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            await response.Content.ReadAsAsync<Product>();
        }
        
        public static IEnumerable<Order> GetOrderData()
        {
            var response = Client.GetAsync("api/order").Result;
            return response.Content.ReadAsAsync<IEnumerable<Order>>().Result;
        }

        public static async Task UpdateOrderAsync(Order oldOrder)
        {
            var order = new Order
            {
                OrderId = oldOrder.OrderId,
                Name = oldOrder.Name,
                email = oldOrder.email,
                PostalCode = oldOrder.PostalCode,
                Status = "Invoiced",
                ProductId = oldOrder.ProductId
            };

            var response = await Client.PutAsJsonAsync(
                $"api/order/{oldOrder.OrderId}", order);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            order = await response.Content.ReadAsAsync<Order>();
        }
    }
}