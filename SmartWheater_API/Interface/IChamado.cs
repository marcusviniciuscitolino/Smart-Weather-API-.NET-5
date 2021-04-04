using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWheater_API.Model;

namespace SmartWheater_API.Areas.Interface
{
    public interface IChamado
    {
        IList<ChamadoModel> GetChamados();
        IList<ChamadoModel> GetChamados(int idChamado);
        void Insert(ChamadoModel chamado);
        void Update(ChamadoModel chamado);
        void Delete(int id);
    }
}
