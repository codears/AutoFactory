using Negocio.Modelo.Interfaces;
using System.Collections.Generic;

namespace Negocio.Negocio.Interfaces
{
    public interface ISecondService
    {
        ICollection<IBaseModel> GetAll();
        IBaseModel GetById(int id);
        void Update(IBaseModel model);
        void Delete(int id);
        void Create(IBaseModel model);
    }
}
