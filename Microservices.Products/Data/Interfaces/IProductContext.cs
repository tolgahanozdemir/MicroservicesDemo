using Microservices.Products.Entities;
using MongoDB.Driver;

namespace Microservices.Products.Data.Interfaces
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
