using WebApi.Domain.Entities.CommonEntities;

namespace WebApi.Domain.Entities.UserManagement
{
    public class User : NameOnlyBaseModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public long? AddressId { get; set; }
    }
}