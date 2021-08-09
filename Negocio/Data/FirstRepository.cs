using Infra.Data.Interfaces;
using Infra.Model;
using Negocio.Context;
using Negocio.Data;

namespace Infra.Data
{
    public class FirstRepository : EfRepository<FirstModel>, IFirstRepository
    {
        public FirstRepository(SimpleContext context) : base(context)
        {
        }
    }
}