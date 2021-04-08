using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWheater_API.Areas.Interface;
using SmartWheater_API.Areas.Repository;
using SmartWheater_API.Model;
using TCC_API_SmartWeather.Areas.Repository;

namespace SmartWheater_API.Areas.DomainModel
{
    public class ChamadoDomainModel : IChamado
    {
        private ChamadoRepository repository = new ChamadoRepository();
        public void Delete(int id)
        {
           repository.Delet(id);
        }

        public IList<ChamadoModel> GetChamados()
        {
            return repository.GetChamado();
        }

        public IList<ChamadoModel> GetChamados(int idChamado)
        {
            return repository.GetChamado(idChamado);
        }

        public void Insert(ChamadoRequest chamado)
        {
            repository.Insert(chamado);
        }

        public void Update(ChamadoModel chamado)
        {
            repository.Update(chamado);
        }
    }
}