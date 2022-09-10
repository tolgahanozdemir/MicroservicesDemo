using Microservices.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Microservices.Products.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name = "test1Name",
                    Summary = "test1Summary",
                    Description = "test1Description",
                    ImageFile = "product-1.png",
                    Price = 1231312,
                    Category = "test1Category"
                },
                new Product
                {
                    Name = "test2Name",
                    Summary = "test2Summary",
                    Description = "test2Description",
                    ImageFile = "product-2.png",
                    Price = 1231312,
                    Category = "test2Category"
                },
                new Product
                {
                    Name = "test3Name",
                    Summary = "test3Summary",
                    Description = "test3Description",
                    ImageFile = "product-3.png",
                    Price = 1231312,
                    Category = "test3Category"
                }
            };
        }
    }
}
