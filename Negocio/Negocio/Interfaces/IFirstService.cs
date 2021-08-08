using Negocio.Modelo.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Negocio.Interfaces
{
    public interface IFirstService
    {
        ICollection<IBaseModel> GetAll();
        IBaseModel GetById(Guid id);
        void Update(IBaseModel model);
        void Delete(Guid id);
        void Create(IBaseModel model);
    }
}