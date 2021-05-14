using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Model
{
    public class StationModel
    {
        //{"_id":{"$oid":"609b1ff8a7b11b00117cf0f6"},"recvTime":{"$date":"2021-05-12T00:23:15.462Z"},"attrName":"ground_humidity","attrType":"float","attrValue":"79"};

        [BsonId]
        public ObjectId _id { get; set; }
        public DateTime recvTime { get; set; }
        public string attrName { get; set; }
        public string attrType { get; set; }
        public string attrValue { get; set; }
    }
}
