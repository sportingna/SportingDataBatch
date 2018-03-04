using MongoDB.Bson;
using System.Collections.Generic;

namespace ProjectDataBatch
{
    internal interface ISportsAPI
    {
        BsonDocument GetBson();
        void RunAPI();
        List<URLModel> GetURLList();
    }
}