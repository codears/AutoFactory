using Infra.Data.Interfaces;
using Infra.Model;
using Infra.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace Infra.Data
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
            return new List<IBaseModel>()
            {
                new SecondModel { Name = "Arley2", Id = 1, ExpirationDate = DateTime.Now },
                new SecondModel { Name = "Nuno2", Id = 2, ExpirationDate = DateTime.Now }
            };
        }

        public IBaseModel GetById(object id)
        {
            return new SecondModel { Id = 1, Name = "Arley", ExpirationDate = DateTime.Now };
        }

        public void Update(IBaseModel model)
        {
            Console.WriteLine("update data access");
        }
    }
}