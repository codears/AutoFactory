using Negocio.Dados.Interfaces;
using Negocio.Modelo.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Dados
{
    public class Repository : IRepository
    {
        public virtual void Create(IBaseModel model)
        {
            Console.WriteLine("create");
        }

        public virtual void Delete(Guid id)
        {
            Console.WriteLine("delete by guid");
        }

        public virtual void Delete(int id)
        {
            Console.WriteLine("delete by int");
        }

        public virtual ICollection<IBaseModel> GetAll()
        {
            Console.WriteLine("get all");
            return default;
        }

        public virtual IBaseModel GetById(Guid id)
        {
            Console.WriteLine("get model by id");
            return default;
        }

        public virtual IBaseModel GetById(int id)
        {
            Console.WriteLine("get model by int");
            return default;
        }

        public virtual void Update(IBaseModel model)
        {
            Console.WriteLine("update model");
        }
    }
}
