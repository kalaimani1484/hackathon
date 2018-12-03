using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonBES.DBContext;
using HackathonBES.Models;
using Microsoft.Extensions.Options;

namespace HackathonBES.Repository
{
    public class SubmissionRepo:ISubmissionRepo
    {
        private readonly MongoContext _context = null;

        public SubmissionRepo(IOptions<Settings> settings)
        {
            _context = new MongoContext(settings);
        }


        //public async Task<List<MongoSubmissionDetail>> GetSubmissionDetail()
        //{
        //    return await _context.MongoSubmissionDetail.Find(_ => true).ToListAsync();
        //}

        public Task<List<SubmissionDetails>> SaveSubmissionDetails()
        {
            throw new NotImplementedException();
        }
    }
}
