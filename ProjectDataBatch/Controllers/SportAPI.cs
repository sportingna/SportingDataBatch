using Newtonsoft.Json;
using System;
using System.IO;
using MongoDB.Bson;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using ProjectDataBatch.Controllers;

namespace ProjectDataBatch
{
    internal class SportAPI : ISportsAPI
    {
        private string results;
        private List<URLModel> urlList;
        public BsonDocument GetBson()
        {
            return MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(results);

        }

        public List<URLModel> GetURLList()
        {
            IMongoDatabase database = new MongoDBContext("Stats").Database;
            var collection = database.GetCollection<BsonDocument>("URL");
            var filter = Builders<BsonDocument>.Filter.Eq("Type", "URL");
            var result = collection.Find(filter).ToList();
            urlList = new List<URLModel>();
            foreach (var url in result)
            {
                
                urlList.Add(BsonSerializer.Deserialize<URLModel>(url));
            }
            ConcatParameterList(urlList);
            return urlList;
        }

        private void ConcatParameterList(List<URLModel> urlList)
        {
            foreach(URLModel url in urlList)
            {
                if (url.Parameters != null)
                {
                    for(int x = 0; x < url.Parameters.Count; x++)
                    {
                        url.Parameter += x == 0 ?  url.Parameters[x].Type : ", "+ url.Parameters[x].Type;      
                    }
                }
                
            }
            
        }

        public bool RunAPI(string get)
        {
            URLModel urlRequest = urlList.Find(x => x.Get == get);
            ISportingRequest request = SportingAPIFactory.GetRequest(get);
            return request.Run(urlRequest);
        }
    }
}