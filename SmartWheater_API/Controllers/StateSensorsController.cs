using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using SmartWheater_API.DomainModel;
using SmartWheater_API.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartWheater_API.Controllers
{
    [Route("api/[controller]")]
    public class StateSensorsController : Controller
    {

        private StateSensorsDomainModel domainModel = new StateSensorsDomainModel();
        private static string entities = "http://18.219.131.199:1026/v2/entities";
        // GET: api/<controller>
        [HttpGet]
        public string Get()
        {
            var client = new RestClient(entities);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("fiware-service", "helixiot");
            request.AddHeader("fiware-servicepath", "/");
            IRestResponse response = client.Execute(request);
            return response.Content;
            //return Json(response.Content);
            //return domainModel.GetStation();
        }

        // GET api/<controller>/5
        [HttpGet("{station}")]
        public string Get(string station)
        {
            var client = new RestClient(string.Concat(entities, "/urn:", station));
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("fiware-service", "helixiot");
            request.AddHeader("fiware-servicepath", "/");
            IRestResponse response = client.Execute(request);
            return response.Content;
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
        // GET api/<controller>/5
        [HttpGet("{station}/{attr}")]
        public IEnumerable<StationModel> GetStationAtrr(string station, string attr)
        {
            string statioSend = "sth_/_urn:ngsi-ld:" + station;
            return domainModel.GetStation(statioSend, attr);
        }
        // GET api/<controller>/5
        [HttpGet("GetStation/{station}")]
        public IEnumerable<StationModel> GetStation(string station)
        {
            string statioSend = "sth_/_urn:ngsi-ld:" + station;
            return domainModel.GetStation(statioSend);
        }


    }
}
