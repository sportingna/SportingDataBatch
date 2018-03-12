using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataBatch
{
    public class Parameter
    {
        [BsonElement("Type")]
        public string Type { get; set; }
        [BsonElement("Position")]
        public Int32 Position { get; set; }
    }
}
