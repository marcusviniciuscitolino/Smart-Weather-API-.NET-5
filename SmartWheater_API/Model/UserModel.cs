using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Areas.Model
{
    public class UserModel
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }
}
