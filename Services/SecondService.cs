using Infra.Data.Interfaces;
using Infra.Model.Interfaces;
using System.Collections.Generic;

namespace Services{
    namespace Interfaces
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

    public class SecondService : Interfaces.ISecondService
    {
        ISecondRepository _secondRepository;

        public SecondService(ISecondRepository secondRepository)
        {
            _secondRepository = secondRepository;
        }

        public void Create(IBaseModel model)
        {
            _secondRepository.Create(model);
        }

        public void Delete(int id)
        {
            _secondRepository.Delete(id);
        }
        public ICollection<IBaseModel> GetAll()
        {
            return _secondRepository.GetAll();
        }

        public IBaseModel GetById(int id)
        {
            return _secondRepository.GetById(id);
        }

        public void Update(IBaseModel model)
        {
            _secondRepository.Update(model);
        }
    }
}