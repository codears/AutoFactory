using Negocio.Modelo.Interfaces;
using System;

namespace Negocio.Modelo
{
    public class BaseModel : IBaseModel
    {
        public DateTime ExpirationDate { get; set; }
    }
}