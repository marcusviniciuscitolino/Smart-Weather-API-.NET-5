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

        public void Insert(ChamadoModel chamado)
        {
            ChamadoContextDB contextDB = new ChamadoContextDB();
            var identity = contextDB.ChamadoCollection.Find(Builders<ChamadoModel>.Filter.Empty).Sort(Builders<ChamadoModel>.Sort.Descending("id")).Limit(1).FirstOrDefault();
            chamado.id = (identity==null)?0:identity.id+1;
            contextDB.ChamadoCollection.InsertOne(chamado);

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
            ChamadoContextDB dbContext = new ChamadoContextDB();
            var filter = (id !=0)?Builders<ChamadoModel>.Filter.Eq("id", id):Builders<ChamadoModel>.Filter.Empty;
            List<ChamadoModel> chamados = dbContext.ChamadoCollection.Find(filter).ToList();
            return chamados;
        }
    }
}
