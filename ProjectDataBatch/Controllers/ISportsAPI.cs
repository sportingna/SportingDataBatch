using MongoDB.Bson;
using System.Collections.Generic;

namespace ProjectDataBatch
{
    interface ISportsAPI
    {
        BsonDocument GetBson();
        bool RunAPI(string get);
        List<URLModel> GetURLList();
    }
}