using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ProjectDataBatch
{
    public class URLModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Get { get; set; }
        public string Parameter { get; set; }
        [BsonElement("Parameters")]
        public List<Parameter> Parameters { get; set; }
        public string Comment { get; set; }
        public string URL { get; set; }
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
    }
}