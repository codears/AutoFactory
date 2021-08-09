using Infra.Data.Interfaces;
using Infra.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    namespace Interfaces
    {
        public interface IFirstService
        {
            Task<ICollection<FirstModel>> GetAll();
            Task<FirstModel> GetById(Guid id);
            Task Update(FirstModel entity);
            Task Delete(Guid id);
            Task Create(FirstModel entity);
        }
    }

    public class FirstService : Interfaces.IFirstService
    {
        IFirstRepository _firstRepository;

        public FirstService(IFirstRepository firstRepository)
        {
            _firstRepository = firstRepository;
        }

        public async Task Create(FirstModel entity)
        {
            Console.WriteLine("create first service");
            await _firstRepository.Create(entity);
        }

        public async Task Delete(Guid id)
        {
            Console.WriteLine("delete first service");
            await _firstRepository.Delete(id);
        }

        public async Task<ICollection<FirstModel>> GetAll()
        {
            Console.WriteLine("get all first service");
            var list = await _firstRepository.GetAll();
            return (ICollection<FirstModel>)list;
        }

        public async Task<FirstModel> GetById(Guid id)
        {
            Console.WriteLine("get by id first service");
            return (FirstModel) await _firstRepository.GetById(id);
        }

        public async Task Update(FirstModel model)
        {
            Console.WriteLine("Update first service");
            await _firstRepository.Update(model);
        }
    }
}