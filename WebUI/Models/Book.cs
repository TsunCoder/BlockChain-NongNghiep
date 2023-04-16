using MongoDB.Bson.Serialization.Attributes;

namespace WebUI.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; } = null!; 

        [BsonElement("email")]
        public int Email { get; set; }

        [BsonElement("phone")]
        public int Phone { get; set; }

        [BsonElement("Role")]
        public string Plot { get; set; } = null!;

        [BsonElement("cast")]
        [BsonIgnoreIfNull]
        public List<string> Cast { get; set; } = null!;
    }
}
