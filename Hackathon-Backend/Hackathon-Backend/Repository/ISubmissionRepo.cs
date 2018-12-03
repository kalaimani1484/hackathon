using HackathonBES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonBES.Repository
{
    interface ISubmissionRepo
    {
        Task<List<SubmissionDetails>> SaveSubmissionDetails();


    }
}
