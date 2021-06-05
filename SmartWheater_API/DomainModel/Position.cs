using SmartWheater_API.Interface;
using SmartWheater_API.Model;
using SmartWheater_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.DomainModel
{
    public class Position : IPosition
    {
        private PositionRepository position = new PositionRepository();
        public void Adicionar(PositionModel model)
        {
            position.IncluirPosition(model);
        }

        public IList<PositionModel> GetPositions(string id=null)
        {
             return position.GetPositions(id);
        }

        public void Update(PositionModel model)
        {
            position.Update(model);       
        }
    }
}
