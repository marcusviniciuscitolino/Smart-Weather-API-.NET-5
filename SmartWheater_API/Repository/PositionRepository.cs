using MongoDB.Driver;
using SmartWheater_API.Context;
using SmartWheater_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Repository
{
    public class PositionRepository
    {
        public void IncluirPosition(PositionModel model)
        {
            PositionContext contextDB = new PositionContext();
            var filter = (!string.IsNullOrEmpty(model.Id)) ? Builders<PositionModel>.Filter.Eq("_id", model.Id) : Builders<PositionModel>.Filter.Empty;
            var identity = contextDB.PosistionCollection.Find(filter).Sort(Builders<PositionModel>.Sort.Descending("Id")).Limit(1).FirstOrDefault();
            if (identity != null)
                throw new Exception("Já existe uma position para essa estação por favor a atualize");
            contextDB.PosistionCollection.InsertOne(model);
        }
        public IList<PositionModel> GetPositions(string id = null)
        {
            PositionContext contextDB = new PositionContext();
            var filter = (!string.IsNullOrEmpty(id)) ? Builders<PositionModel>.Filter.Eq("_id", id) : Builders<PositionModel>.Filter.Empty;
            IList<PositionModel> positions = contextDB.PosistionCollection.Find(filter).ToList();
            return positions;
        }
        public void Update(PositionModel model)
        {
            PositionContext dbContext = new PositionContext();
            dbContext.PosistionCollection.ReplaceOne(m => m.Id == model.Id, model);
        }
    }
}
