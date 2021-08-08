using Negocio.Modelo.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Dados.Interfaces
{
    public interface IFirstRepository
    {
        ICollection<IBaseModel> GetAll();
        IBaseModel GetById(Guid id);
        void Update(IBaseModel model);
        void Delete(Guid id);
        void Create(IBaseModel model);
    }
}