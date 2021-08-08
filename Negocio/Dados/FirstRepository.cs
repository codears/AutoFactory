using Negocio.Dados.Interfaces;
using Negocio.Modelo;
using Negocio.Modelo.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Dados
{
    public class FirstRepository : Repository, IFirstRepository
    {
        readonly IDataAccess _dataAccess;

        public FirstRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public override void Create(IBaseModel model)
        {
            Console.WriteLine("create first repository");
            _dataAccess.Create(model);
        }

        public override IBaseModel GetById(Guid id)
        {
            return new FirstModel { Id = id, Name = "Arley", ExpirationDate = DateTime.Now };
        }

        public override ICollection<IBaseModel> GetAll()
        {
            Console.WriteLine("get all first repository");
            return new List<IBaseModel>()
            {
                new FirstModel { Name = "Arley", Id = Guid.NewGuid(), ExpirationDate = DateTime.Now },
                new FirstModel { Name = "Nuno", Id = Guid.NewGuid(), ExpirationDate = DateTime.Now }
            };
        }

        public override void Update(IBaseModel model)
        {
            base.Update(model);
        }

        public override void Delete(Guid id)
        {
            base.Delete(id);
        }
    }
}