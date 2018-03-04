using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProjectDataBatch
{
    class MongoDBContext
    {
        public IMongoDatabase Database { get; private set; }

        public MongoDBContext(string db)
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl(ConfigurationManager.ConnectionStrings["LocalMongo"].ToString()));
            var mongoClient = new MongoClient(settings);
            Database = mongoClient.GetDatabase(db);

        }


    }
}
