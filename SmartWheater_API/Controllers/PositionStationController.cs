using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWheater_API.DomainModel;
using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionStationController : ControllerBase
    {
        private static Position domainModel = new Position(); 
        [HttpPost]
        public void Post([FromBody]PositionModel value)
        {
            domainModel.Adicionar(value);
        }
        [HttpGet]
        public IList<PositionModel> Get()
        {
            return domainModel.GetPositions();
        }
        [HttpGet("{id}")]
        public IList<PositionModel> Get(string id)
        {
            return domainModel.GetPositions(id);
        }
        [HttpPut]
        public void Put([FromBody] PositionModel value)
        {
            domainModel.Update(value);
        }
    }
}
