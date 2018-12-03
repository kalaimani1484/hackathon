using HackathonBES.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonBES.DBContext
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database = null;

        public MongoContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }
        
        public IMongoCollection<SubmissionDetails> MongoSubmissionDetail
        {
            get
            {
                return _database.GetCollection<SubmissionDetails>("Submissions");
            }
        }
    }
}
