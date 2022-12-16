using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace the_spacery.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
    }
}
