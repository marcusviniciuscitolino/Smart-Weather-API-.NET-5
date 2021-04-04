using SmartWheater_API.Areas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Interface
{
    interface IUserDomainModel
    {
        UserModel GetUser(UserModel model);
        void Insert(UserModel model);
        void Delete(string user);
    }
}
