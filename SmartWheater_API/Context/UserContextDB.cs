using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using SmartWheater_API.Areas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Context
{
    public class UserContextDB
    {
        private static string _ConnectionString = "mongodb://helix:H3l1xNG@18.219.131.199:27000/?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false";
        private static string _DatabaseName = "sth_helixiot";
        private IMongoDatabase _database { get; }

        public UserContextDB()
        {
            _database = new MongoDBContext(_ConnectionString, _DatabaseName)._dataBase;
        }
        public IMongoCollection<UserModel> UserCollection
        {
            get
            {
                return _database.GetCollection<UserModel>("User");
            }

        }
    }
}
