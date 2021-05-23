using MongoDB.Driver;
using SmartWheater_API.Context;
using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Repository
{
    public class StateSensorsRepository
    {
        public IList<StationModel> GetStateSensors(string stationID, string attrName)
        {
            var filter = Builders<StationModel>.Filter.Eq("attrName", attrName);
            //sth_/_urn:ngsi-ld:station:006_station
            StationContext station = new StationContext(stationID);
            List<StationModel> dynamics = station.UserCollection.Find(filter).ToList();
            return dynamics;
        }
        public IList<StationModel> GetStateSensors(string stationID)
        {
            var filter = Builders<StationModel>.Filter.Empty;
            //sth_/_urn:ngsi-ld:station:006_station
            StationContext station = new StationContext(stationID);
            List<StationModel> dynamics = station.UserCollection.Find(filter).ToList();
            return dynamics;
        }
    }
}
