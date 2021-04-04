using SmartWheater_API.Areas.Model;
using SmartWheater_API.Areas.Repository;
using SmartWheater_API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.DomainModel
{
    public class UserDomainModel : IUserDomainModel
    {
        public void Delete(string user)
        {
            UserRepository.Delete(user);
        }

        public UserModel GetUser(UserModel model)
        {
            return UserRepository.Get(model);
        }

        public void Insert(UserModel model)
        {
            UserRepository.Post(model);
        }
    }
}
