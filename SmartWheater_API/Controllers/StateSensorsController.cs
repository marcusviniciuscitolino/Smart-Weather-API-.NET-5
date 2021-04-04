using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartWheater_API.DomainModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartWheater_API.Controllers
{
    [Route("api/[controller]")]
    public class StateSensorsController : Controller
    {
        private StateSensorsDomainModel domainModel = new StateSensorsDomainModel();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            return domainModel.GetStation();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
