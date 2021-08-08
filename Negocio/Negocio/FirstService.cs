using Negocio.Dados.Interfaces;
using Negocio.Modelo.Interfaces;
using Negocio.Negocio.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Negocio
{
    public class FirstService : IFirstService
    {
        IFirstRepository _firstRepository;

        public FirstService(IFirstRepository firstRepository)
        {
            _firstRepository = firstRepository;
        }

        public void Create(IBaseModel model)
        {
            Console.WriteLine("create first service");
            _firstRepository.Create(model);
        }

        public void Delete(Guid id)
        {
            Console.WriteLine("delete first service");
            _firstRepository.Delete(id);
        }

        public ICollection<IBaseModel> GetAll()
        {
            Console.WriteLine("get all first service");
            return _firstRepository.GetAll();
        }

        public IBaseModel GetById(Guid id)
        {
            Console.WriteLine("get by id first service");
            return _firstRepository.GetById(id);
        }

        public void Update(IBaseModel model)
        {
            Console.WriteLine("Update first service");
            _firstRepository.Update(model);
        }
    }
}