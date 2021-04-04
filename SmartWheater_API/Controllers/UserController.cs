using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartWheater_API.Areas.Model;
using SmartWheater_API.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserDomainModel domainModel = new UserDomainModel();
        [HttpPost]
        [Authorize(Roles = "manager,masteruser")]
        public void Post([FromBody] UserModel value)
        {
            domainModel.Insert(value);
        }
        [HttpDelete]
        [Authorize(Roles = "masteruser")]
        public void Delete([FromBody] string user)
        {
            domainModel.Delete(user);
        }
    }
}
