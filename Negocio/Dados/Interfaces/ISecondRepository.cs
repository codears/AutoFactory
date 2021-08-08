using Negocio.Modelo.Interfaces;
using System.Collections.Generic;

namespace Negocio.Dados.Interfaces
{
    public interface ISecondRepository 
    {
        ICollection<IBaseModel> GetAll();
        IBaseModel GetById(int id);
        void Update(IBaseModel model);
        void Delete(int id);
        void Create(IBaseModel model);
    }
}