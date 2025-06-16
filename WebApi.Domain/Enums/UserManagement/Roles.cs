using System.ComponentModel;

namespace WebApi.Domain.Enums.UserManagement
{
    public enum Roles
    {
        [Description("Admin")]
        Admin = 1,

        [Description("App User")]
        AppUser = 2
    }
}
