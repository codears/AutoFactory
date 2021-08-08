using Negocio.Dados.Interfaces;
using Negocio.Modelo;
using Negocio.Modelo.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Dados
{
    public class SecondRepository : Repository, ISecondRepository
    {
        readonly IDataAccess _dataAccess;

        public SecondRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public override void Create(IBaseModel model)
        {
            Console.WriteLine("create second repository");
            _dataAccess.Create(model);
        }

        public IBaseModel GetById(int id)
        {
            return new SecondModel { Id = 1, Name = "Arley", ExpirationDate = DateTime.Now };
        }

        public override ICollection<IBaseModel> GetAll()
        {
            Console.WriteLine("get all second repository");
            return new List<IBaseModel>()
            {
                new FirstModel { Name = "Arley2", Id = Guid.NewGuid(), ExpirationDate = DateTime.Now },
                new FirstModel { Name = "Nuno2", Id = Guid.NewGuid(), ExpirationDate = DateTime.Now }
            };
        }

        public override void Update(IBaseModel model)
        { 
            Console.WriteLine("Update second repository");
            base.Update(model);
        }

        public void Delete(int id)
        {
            Console.WriteLine("delete second repository");
            _dataAccess.Delete(id);
        }
    }
}
