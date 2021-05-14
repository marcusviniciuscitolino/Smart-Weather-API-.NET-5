using MongoDB.Driver;
using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Context
{
    public class StationContext
    {
        private static string _ConnectionString = "mongodb://helix:H3l1xNG@18.219.131.199:27000/?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false";
        private static string _DatabaseName = "sth_helixiot";
        private static string _Collection = "";
        private IMongoDatabase _database { get; }

        public StationContext(string colleection)
        {
            _Collection = colleection;
            _database = new MongoDBContext(_ConnectionString, _DatabaseName)._dataBase;
        }
        public IMongoCollection<StationModel> UserCollection
        {
            get
            {
                return _database.GetCollection<StationModel>(_Collection);
            }

        }
    }
}
