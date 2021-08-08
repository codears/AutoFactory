using Negocio.Modelo.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Dados.Interfaces
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