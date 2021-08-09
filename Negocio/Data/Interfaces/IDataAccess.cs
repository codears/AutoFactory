using Infra.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace Infra.Data.Interfaces
{
    public interface IDataAccess
    {
        ICollection<IBaseModel> GetAll();
        IBaseModel GetById(object id);
        void Update(IBaseModel model);
        void Delete(object id);
        void Create(IBaseModel model);
    }
}