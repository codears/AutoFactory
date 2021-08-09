using Infra.Model.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Infra.Model
{
    public class BaseModel : IBaseModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime ExpirationDate { get; set; }
    }
}