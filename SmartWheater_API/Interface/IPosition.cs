using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Interface
{
    interface IPosition
    {
        public void Adicionar(PositionModel model);
        public IList<PositionModel> GetPositions(string id = null);
        public void Update(PositionModel model);
    }
}
