using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Interface
{
    public interface IStateSensors
    {
        IList<dynamic> GetStation();
        IList<dynamic> GetStation(int idStation);
        int Insert(dynamic Station);
        bool UpdateStation(dynamic Station);
        bool DeletStation(dynamic id);
    }
}
