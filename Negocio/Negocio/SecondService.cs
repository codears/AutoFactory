using Negocio.Dados.Interfaces;
using Negocio.Modelo.Interfaces;
using Negocio.Negocio.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Negocio
{
    public class SecondService : ISecondService
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