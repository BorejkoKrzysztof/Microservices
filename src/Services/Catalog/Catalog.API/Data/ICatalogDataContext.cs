using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogDataContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
