using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWheater_API.Model;
using SmartWheater_API.Areas.DomainModel;
using Microsoft.AspNetCore.Authorization;

namespace SmartWheater_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChamadoController : ControllerBase
    {
        private ChamadoDomainModel domainModel = new ChamadoDomainModel();
        
        [HttpGet]
        [Authorize]
        public IEnumerable<ChamadoModel> Get()
        {
            return domainModel.GetChamados();
        }

        [HttpGet("{id}")]
        [Authorize]
        public IEnumerable<ChamadoModel> Get(int id)
        {
            return domainModel.GetChamados(id);
        }

        [HttpPost]
        [Authorize]
        public void Post([FromBody] ChamadoRequest value)
        {
            domainModel.Insert(value);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void Put([FromBody] ChamadoModel value)
        {
            domainModel.Update(value);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public void Delete(int id)
        {
            domainModel.Delete(id);
        }
    }
}