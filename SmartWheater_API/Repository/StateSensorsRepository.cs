using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Repository
{
    public class StateSensorsRepository
    {
        public IList<dynamic> GetStateSensors(int id = 0)
        {
            GenericContextRepository dbContext = new GenericContextRepository();
            List<dynamic> listaNotas = dbContext.StateSensors.Find(m => true).ToList();
            return listaNotas;
        }
    }
}
