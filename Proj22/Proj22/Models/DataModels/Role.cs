using Microsoft.AspNetCore.Identity;

namespace Proj22.Models.DataModels
{
    public class Role : IdentityRole<int>
    {
        public virtual RoleValue RoleValue { get; set; }
        public Role() { }

        public Role(string name, RoleValue roleValue)
        {
            RoleValue = roleValue;
        }

    }
}
