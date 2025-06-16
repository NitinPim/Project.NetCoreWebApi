using Lib.Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Entities.CommonEntities
{
    public class NameOnlyBaseModel : EntityBase
    {
        [Required]
        public string? Name { get; set; }

    }
}
