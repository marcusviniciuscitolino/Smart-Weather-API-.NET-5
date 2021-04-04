using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWheater_API.Model;
using SmartWheater_API.Areas.DomainModel;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartWheater_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChamadoController : ControllerBase
    {
        private ChamadoDomainModel domainModel = new ChamadoDomainModel();
        // GET: api/<ValuesController>
        [HttpGet]
        [Authorize]
        public IEnumerable<ChamadoModel> Get()
        {
            return domainModel.GetChamados();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        [Authorize]
        public IEnumerable<ChamadoModel> Get(int id)
        {
            return domainModel.GetChamados(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Authorize]
        public void Post([FromBody] ChamadoModel value)
        {
            domainModel.Insert(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        [Authorize]
        public void Put([FromBody] ChamadoModel value)
        {
            domainModel.Update(value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public void Delete(int id)
        {
            domainModel.Delete(id);
        }
    }
}
