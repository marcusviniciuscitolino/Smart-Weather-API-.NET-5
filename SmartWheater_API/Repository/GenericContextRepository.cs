using MongoDB.Driver;
using SmartWheater_API.Areas.Model;
using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Repository
{
    public class GenericContextRepository
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }
        public string Base { get; set; }

        private IMongoDatabase _database { get; }

        public GenericContextRepository()
        {
            try
            {
                ConnectionString = "mongodb://helix:H3l1xNG@18.219.131.199:27000/?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false";
                DatabaseName = "sth_helixiot";
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }
        public IMongoCollection<UserModel> UserCollection
        {
            get
            {
                return _database.GetCollection<UserModel>("User");
            }

        }
        public IMongoCollection<dynamic> StateSensors
        {
            get
            {
                return _database.GetCollection<dynamic>("sth_/_Thing:Mesh_Thing");
            }
        }
        public IMongoCollection<ChamadoModel> ChamadoModel
        {
            get
            {
                return _database.GetCollection<ChamadoModel>("ChamadoModel");
            }
        }
    }
}
