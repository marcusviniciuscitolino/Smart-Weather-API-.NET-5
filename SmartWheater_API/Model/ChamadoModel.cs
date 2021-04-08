using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace SmartWheater_API.Model
{
    public class ChamadoModel:ChamadoRequest
	{
		[BsonId]
		public ObjectId _id { get; set; }
        public int id { get; set; }

	}
}