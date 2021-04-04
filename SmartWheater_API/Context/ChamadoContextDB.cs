using MongoDB.Driver;
using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Context
{
    public class ChamadoContextDB
    {
        private static string _ConnectionString = "mongodb://helix:H3l1xNG@18.219.131.199:27000/?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false";
        private static string _DatabaseName = "sth_helixiot";
        private IMongoDatabase _database { get; }

        public ChamadoContextDB()
        {
            _database = new MongoDBContext(_ConnectionString, _DatabaseName)._dataBase;
        }
        public IMongoCollection<ChamadoModel> ChamadoCollection
        {
            get
            {
                return _database.GetCollection<ChamadoModel>("Chamado");
            }

        }
    }
}
