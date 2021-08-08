using Negocio.Dados.Interfaces;
using Negocio.Modelo.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Dados
{
    public class DataAccess : IDataAccess
    {
        public void Create(IBaseModel model)
        {
            Console.WriteLine("Create data access");
        }

        public void Delete(object id)
        {
            Console.WriteLine("Delete data access");
        }

        public ICollection<IBaseModel> GetAll()
        {
            Console.WriteLine("Get all data access");
            return default;
        }

        public IBaseModel GetById(object id)
        {
            Console.WriteLine("Get by id data access");
            return default;
        }

        public void Update(IBaseModel model)
        {
            Console.WriteLine("update data access");
        }
    }
}