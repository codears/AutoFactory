using Infra.Model.Interfaces;
using System.Collections.Generic;

namespace Infra.Data.Interfaces
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