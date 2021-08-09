using Infra.Data.Interfaces;
using Infra.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace Infra.Data
{
    public class SecondRepository : Repository, ISecondRepository
    {
        readonly IDataAccess _dataAccess;

        public SecondRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public override void Create(IBaseModel model)
        {
            Console.WriteLine("create second repository");
            _dataAccess.Create(model);
        }

        public override IBaseModel GetById(int id)
        {
            return _dataAccess.GetById(id);
        }

        public override ICollection<IBaseModel> GetAll()
        {
            Console.WriteLine("get all second repository");
            return _dataAccess.GetAll();
        }

        public override void Update(IBaseModel model)
        { 
            Console.WriteLine("Update second repository");
            base.Update(model);
        }

        public override void Delete(int id)
        {
            Console.WriteLine("delete second repository");
            _dataAccess.Delete(id);
        }
    }
}
