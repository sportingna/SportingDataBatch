using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataBatch.Util
{
    class SportAPIUtil
    {
        public const string Areas = "Areas (Countries)";
        public const string Schedule = "Schedule";
        public const string LeagueHierarchy = "Competition Hierarchy (League Hierarchy)";
        public const string TeamGameStatByDate = "Team Game Stats by Date";
        public const string Standings = "Standings";
        public const string PlayersByTeam = "Players by Team";
        public const string CompetitionFixtures = "Competition Fixtures (League Details)";
        public const string PlayerGameStatsByDate = "Player Game Stats by Date";
        public const string PlayerSeasonStatsByTeam = "Player Season Stats by Team";
        public const string GamesByDate = "Games by Date";
        public const string BoxScore = "Box Score";
        public const string CompetitionsByGameId = "Competitions (Leagues) By GameId ";
        public const string BoxScoresByDateAndCompetition = "Box Scores by Date by Competition";
        public const string Competitions = "Competitions (Leagues)";

        public static string SubscriptionKey { get; private set; }

        private void SetSubscriptionKey()
        {
            string key = "";

            var db = new MongoDBContext("Stats").Database;
            var collection = db.GetCollection<BsonDocument>("URL");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.And(builder.Eq("Type", "PrimaryKey"), builder.Eq("Title", "FantasyData API"));
            
            var result = collection.Find(filter).ToList();

            SubscriptionKey = key;
        }
    }
}
