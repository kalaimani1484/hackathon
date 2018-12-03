using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonBES.Models
{
    public class SubmissionDetails
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string applicantname { get; set; }

        [BsonDateTimeOptions]
        public DateTime? expirationdate { get; set; }

        [BsonDateTimeOptions]
        public DateTime? inceptiondate { get; set; }
        public string mgcis { get; set; }
        public string city { get; set; }
        public string coverages { get; set; }
        public string domicilestate { get; set; }
        public string mailingaddress { get; set; }
        public string natureofoperations { get; set; }
        public string state { get; set; }

        [BsonDateTimeOptions]
        public DateTime? submissionreceiveddate { get; set; }
        public string wsgusa { get; set; }
        public string zip { get; set; }
    }
}
