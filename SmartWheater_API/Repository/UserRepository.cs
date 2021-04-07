using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SmartWheater_API.Areas.Model;
using SmartWheater_API.Context;
using SmartWheater_API.Model;
using SmartWheater_API.Repository;

namespace SmartWheater_API.Areas.Repository
{
    public static class UserRepository
    {
        public static UserModel Get(UserRequest user)
        {
            UserContextDB genericContext = new UserContextDB();
            return genericContext.UserCollection.Find(m => m.username == user.username && m.password == user.password).FirstOrDefault();
        }
        public static void Post(UserModel user)
        {
            UserContextDB dbContext = new UserContextDB();
            dbContext.UserCollection.InsertOne(user);

        }

        public static void Delete(string user)
        {
            UserContextDB dbContext = new UserContextDB();
            dbContext.UserCollection.DeleteOne(m => m.username == user);
        }
    }
}