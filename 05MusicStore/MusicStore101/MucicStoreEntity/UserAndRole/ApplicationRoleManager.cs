using Microsoft.AspNet.Identity;

namespace MucicStoreEntity.UserAndRole
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole>
    {
        public ApplicationRoleManager(IRoleStore<ApplicationRole, string> store)
            : base(store)
        {
        }
    }
}