using MongoDB.Driver;
using SmartWheater_API.Context;
using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace TCC_API_SmartWeather.Areas.Repository
{
    public class ChamadoRepository
    {

        public void Insert(ChamadoRequest chamado)
        {
            ChamadoModel model = new ChamadoModel()
            {
                DateClosed = chamado.DateClosed,
                DateOpen = chamado.DateOpen,
                DescCalled = chamado.DescCalled,
                FarmeSize = chamado.FarmeSize,
                IdPriority = chamado.IdPriority,
                IdProblem = chamado.IdProblem,
                NameFarmer = chamado.NameFarmer,
                NameTec = chamado.NameTec,
                Sla = chamado.Sla,
                StatusCalled = chamado.StatusCalled        
            };
            ChamadoContextDB contextDB = new ChamadoContextDB();
            var identity = contextDB.ChamadoCollection.Find(Builders<ChamadoModel>.Filter.Empty).Sort(Builders<ChamadoModel>.Sort.Descending("id")).Limit(1).FirstOrDefault();
            model.id = (identity==null)?0:identity.id+1;
            contextDB.ChamadoCollection.InsertOne(model);

        }
        public void Update(ChamadoModel chamado)
        {
            ChamadoContextDB dbContext = new ChamadoContextDB();
            dbContext.ChamadoCollection.ReplaceOne(m => m.id == chamado.id, chamado);
        }
        public void Delet(int id)
        {
            ChamadoContextDB dbContext = new ChamadoContextDB();
            dbContext.ChamadoCollection.DeleteOne(m => m.id == id);
        }
        public IList<ChamadoModel> GetChamado(int id = 0)
        {
            StationContext station = new StationContext("sth_/_urn:ngsi-ld:station:006_station");
            List<StationModel> dynamics = station.UserCollection.Find(Builders<StationModel>.Filter.Empty).ToList();
            ChamadoContextDB dbContext = new ChamadoContextDB();
            var filter = (id !=0)?Builders<ChamadoModel>.Filter.Eq("id", id):Builders<ChamadoModel>.Filter.Empty;
            List<ChamadoModel> chamados = dbContext.ChamadoCollection.Find(filter).ToList();
            return chamados;


        }
    }
}