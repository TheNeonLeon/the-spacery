using Microsoft.Extensions.Options;
using MongoDB.Driver;
using the_spacery.Models;

namespace the_spacery.Services
{
    public class SpaceService
    {
        private readonly IMongoCollection<Product> _productCollection;
        public SpaceService(
        IOptions<SpaceStoreDatabaseSettings> spaceStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                spaceStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                spaceStoreDatabaseSettings.Value.DatabaseName);

            _productCollection = mongoDatabase.GetCollection<Product>(
                spaceStoreDatabaseSettings.Value.SpaceCollectionName);
        }
        public async Task<List<Product>> GetAsync() =>
       await _productCollection.Find(_ => true).ToListAsync();

        public async Task<Product?> GetAsync(string id) =>
            await _productCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Product newProduct) =>
            await _productCollection.InsertOneAsync(newProduct);

        public async Task UpdateAsync(string id, Product updatedProduct) =>
            await _productCollection.ReplaceOneAsync(x => x.Id == id, updatedProduct);

        public async Task RemoveAsync(string id) =>
            await _productCollection.DeleteOneAsync(x => x.Id == id);

    }
}
