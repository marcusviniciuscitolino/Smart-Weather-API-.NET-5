using SmartWheater_API.Interface;
using SmartWheater_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.DomainModel
{
    public class StateSensorsDomainModel : IStateSensors
    {
        private StateSensorsRepository repository = new StateSensorsRepository();
        public bool DeletStation(dynamic id)
        {
            throw new NotImplementedException();
        }

        public IList<dynamic> GetStation()
        {
           return repository.GetStateSensors();
        }

        public IList<dynamic> GetStation(int idStation)
        {
            throw new NotImplementedException();
        }

        public int Insert(dynamic Station)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStation(dynamic Station)
        {
            throw new NotImplementedException();
        }
    }
}
