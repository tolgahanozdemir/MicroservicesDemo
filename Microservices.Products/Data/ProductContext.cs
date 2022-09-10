using Microservices.Products.Data.Interfaces;
using Microservices.Products.Entities;
using Microservices.Products.Settings;
using MongoDB.Driver;

namespace Microservices.Products.Data
{
    public class ProductContext : IProductContext
    {
        public ProductContext(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionStrings);
            var database = client.GetDatabase(settings.DatabaseName);

            Products = database.GetCollection<Product>(settings.CollectionName);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
